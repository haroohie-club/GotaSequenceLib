namespace GotaSequenceLib.Playback
{
    public abstract class AbstractTrack
    {
        public readonly byte Index;
        protected readonly Player _player;


        // Track state
        public bool Allocated;
        public bool Enabled;
        public bool Stopped;
        public int CurEvent;
        public bool VariableFlag;
        public int Rest;
        public int[] CallStack = new int[3];
        public byte[] CallStackLoops = new byte[3];
        public byte CallStackDepth;
        public bool WaitingForNoteToFinishBeforeContinuingXD; // Is this necessary?
        public bool NoteDown;

        // *SEQ properties 
        abstract public bool Tie { get; set; }
        abstract public bool NoteWait { get; set; } // previously known as Mono
        abstract public bool Portamento { get; set; }
        abstract public int Voice { get; set; }
        abstract public byte Priority { get; set; }
        abstract public byte Volume { get; set; }
        abstract public byte Expression { get; set; }
        abstract public byte LFORange { get; set; }
        abstract public byte PitchBendRange { get; set; }
        abstract public byte LFOSpeed { get; set; }
        abstract public byte LFODepth { get; set; }
        abstract public ushort LFODelay { get; set; }
        abstract public ushort LFOPhase { get; set; }
        abstract public ushort LFODelayCount { get; set; }
        abstract public LFOType LFOType { get; set; }
        abstract public sbyte PitchBend { get; set; }
        abstract public sbyte Panpot { get; set; }
        abstract public sbyte Transpose { get; set; }
        abstract public byte Attack { get; set; }
        abstract public byte Decay { get; set; }
        abstract public byte Sustain { get; set; }
        abstract public byte Hold { get; set; }
        abstract public byte Release { get; set; }
        abstract public byte PortamentoKey { get; set; }
        abstract public byte PortamentoTime { get; set; }
        abstract public short SweepPitch { get; set; }
        abstract public int BankNum { get; set; }

        public class TrackVars
        {
            private readonly Player _player;
            private readonly short[] _trackVars = new short[0x10];

            public short this[int i]
            {
                get
                {
                    if (i < 0x20)
                    {
                        return _player.Vars[i];
                    }
                    else
                    {
                        return _trackVars[i - 0x20];
                    }
                }
                set
                {
                    if (i < 0x20)
                    {
                        _player.Vars[i] = value;
                    }
                    else
                    {
                        _trackVars[i - 0x20] = value;
                    }
                }
            }

            internal TrackVars(Player player)
            {
                _player = player;
            }
        }

        public readonly TrackVars Vars;

        protected AbstractTrack(byte idx, Player player)
        {
            Index = idx;
            _player = player;
            Vars = new TrackVars(player);
        }


    }

    // public enum LFOType
    // {
    //     Pitch,
    //     Volume,
    //     Panpot
    // }
}
