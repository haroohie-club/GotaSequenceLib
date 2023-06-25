

using Sanford.Multimedia.Midi;

namespace GotaSequenceLib.Playback
{
    public class MidiTrack : AbstractTrack
    {
        private readonly Sanford.Multimedia.Midi.Track _track = new Sanford.Multimedia.Midi.Track();

        // *SEQ properties
        private bool _tie = false;
        override public bool Tie
        {
            get { return _tie; }
            set
            {
                _tie = value;
                Message(new ChannelMessage(ChannelCommand.Controller, Index, (int)ControllerType.AllNotesOff));
            }
        }

        private bool _noteWait = true;
        override public bool NoteWait { get { return _noteWait; } set { _noteWait = value; } } // AKA NoteWait?
        override public bool Portamento { get; set; }
        override public int Voice { get; set; }
        override public byte Priority { get; set; }
        override public byte Volume { get; set; }
        override public byte Expression { get; set; }
        override public byte LFORange { get; set; }
        override public byte PitchBendRange { get; set; }
        override public byte LFOSpeed { get; set; }
        override public byte LFODepth { get; set; }
        override public ushort LFODelay { get; set; }
        override public ushort LFOPhase { get; set; }
        override public ushort LFODelayCount { get; set; }
        override public LFOType LFOType { get; set; }
        override public sbyte PitchBend { get; set; }
        override public sbyte Panpot { get; set; }
        override public sbyte Transpose { get; set; }
        override public byte Attack { get; set; }
        override public byte Decay { get; set; }
        override public byte Sustain { get; set; }
        override public byte Hold { get; set; }
        override public byte Release { get; set; }
        override public byte PortamentoKey { get; set; }
        override public byte PortamentoTime { get; set; }
        override public short SweepPitch { get; set; }
        override public int BankNum { get; set; }

        private void Message(ChannelMessage message)
        {
            _track.Insert((int)_player.ElapsedTicks, message);
        }

        public MidiTrack(byte idx, Player player) : base(idx, player)
        {

        }
    }
}
