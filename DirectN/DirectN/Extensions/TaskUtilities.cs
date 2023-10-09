using System;
using System.Threading;
using System.Threading.Tasks;

namespace DirectN
{
    public static class TaskUtilities
    {
        public static async void Forget(this Task task, params Type[] acceptableExceptions)
        {
            if (task == null)
                return;

            try
            {
                await task.ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                if (acceptableExceptions == null || acceptableExceptions.Length == 0)
                    throw;

                foreach (var ae in acceptableExceptions)
                {
                    if (ae.IsAssignableFrom(ex.GetType()))
                        return;
                }

                throw;
            }
        }

        public static Task<T> RunWithNewSTAThread<T>(Func<T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            var tcs = new TaskCompletionSource<T>();
            var thread = new Thread(() =>
            {
                try
                {
                    tcs.SetResult(func());
                }
                catch (Exception e)
                {
                    tcs.SetException(e);
                }
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            return tcs.Task;
        }

        public static Task<T> RunWithSTAThread<T>(Func<T> func, bool startNew = false)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            if (startNew || Thread.CurrentThread.GetApartmentState() != ApartmentState.STA)
                return RunWithNewSTAThread(func);

            return Task.FromResult(func());
        }

        public static Task RunWithNewSTAThread(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            return RunWithNewSTAThread(() =>
            {
                action();
                return true;
            });
        }

        public static Task RunWithSTAThread(Action action, bool startNew = false)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (startNew || Thread.CurrentThread.GetApartmentState() != ApartmentState.STA)
                return RunWithNewSTAThread(action);

            action();
            return Task.CompletedTask;
        }
    }
}
