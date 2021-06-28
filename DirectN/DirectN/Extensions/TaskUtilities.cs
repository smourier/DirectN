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
                throw new ArgumentNullException(nameof(task));

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

        public static Task<T> StartSTAThreadTask<T>(Func<T> func)
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

        public static Task StartSTAThreadTask(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            return StartSTAThreadTask(() =>
            {
                action();
                return true;
            });
        }
    }
}
