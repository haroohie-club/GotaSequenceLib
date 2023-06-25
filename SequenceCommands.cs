﻿namespace GotaSequenceLib
{
    /// <summary>
    /// Sequence command id.
    /// </summary>
    public enum SequenceCommands
    {
        Note,
        Wait = 0x80,
        ProgramChange,
        OpenTrack,
        Jump,
        Call,
        Random,
        Variable,
        If,
        Time,
        TimeRandom,
        TimeVariable,
        Timebase,
        EnvHold,
        Monophonic,
        VelocityRange,
        BiquadType,
        BiquadValue,
        BankSelect,
        ModPhase,
        ModCurve,
        FrontBypass,
        Pan,
        Volume,
        MainVolume,
        Transpose,
        PitchBend,
        BendRange,
        Prio,
        NoteWait,
        Tie,
        Porta,
        ModDepth,
        ModSpeed,
        ModType,
        ModRange,
        PortaSw,
        PortaTime,
        Attack,
        Decay,
        Sustain,
        Release,
        LoopStart,
        Volume2,
        PrintVar,
        SurroundPan,
        LpfCutoff,
        FxSendA,
        FxSendB,
        MainSend,
        InitPan,
        Mute,
        FxSendC,
        Damper,
        ModDelay,
        Tempo,
        SweepPitch,
        ModPeriod,
        EnvReset,
        LoopEnd,
        Return,
        AllocateTrack,
        Fin,
        Extended,
        SetVar,
        AddVar,
        SubVar,
        MulVar,
        DivVar,
        ShiftVar,
        RandVar,
        AndVar,
        OrVar,
        XorVar,
        NotVar,
        ModVar,
        CmpEq,
        CmpGe,
        CmpGt,
        CmpLe,
        CmpLt,
        CmpNe,
        Mod2Curve,
        Mod2Phase,
        Mod2Depth,
        Mod2Speed,
        Mod2Type,
        Mod2Range,
        Mod2Delay,
        Mod2Period,
        Mod3Curve,
        Mod3Phase,
        Mod3Depth,
        Mod3Speed,
        Mod3Type,
        Mod3Range,
        Mod3Delay,
        Mod3Period,
        Mod4Curve,
        Mod4Phase,
        Mod4Depth,
        Mod4Speed,
        Mod4Type,
        Mod4Range,
        Mod4Delay,
        Mod4Period,
        UserCall
    }
}
