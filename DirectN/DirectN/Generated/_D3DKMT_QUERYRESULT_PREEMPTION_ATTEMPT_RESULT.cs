// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(3157,9)
namespace DirectN
{
    public enum _D3DKMT_QUERYRESULT_PREEMPTION_ATTEMPT_RESULT
    {
        D3DKMT_PreemptionAttempt = 0,
        D3DKMT_PreemptionAttemptSuccess = 1,
        D3DKMT_PreemptionAttemptMissNoCommand = 2,
        D3DKMT_PreemptionAttemptMissNotEnabled = 3,
        D3DKMT_PreemptionAttemptMissNextFence = 4,
        D3DKMT_PreemptionAttemptMissPagingCommand = 5,
        D3DKMT_PreemptionAttemptMissSplittedCommand = 6,
        D3DKMT_PreemptionAttemptMissFenceCommand = 7,
        D3DKMT_PreemptionAttemptMissRenderPendingFlip = 8,
        D3DKMT_PreemptionAttemptMissNotMakingProgress = 9,
        D3DKMT_PreemptionAttemptMissLessPriority = 10,
        D3DKMT_PreemptionAttemptMissRemainingQuantum = 11,
        D3DKMT_PreemptionAttemptMissRemainingPreemptionQuantum = 12,
        D3DKMT_PreemptionAttemptMissAlreadyPreempting = 13,
        D3DKMT_PreemptionAttemptMissGlobalBlock = 14,
        D3DKMT_PreemptionAttemptMissAlreadyRunning = 15,
        D3DKMT_PreemptionAttemptStatisticsMax = 16,
    }
}
