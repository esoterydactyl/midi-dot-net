// Copyright (c) 2009, Tom Lokovic
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are met:
//
//     * Redistributions of source code must retain the above copyright notice,
//       this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright
//       notice, this list of conditions and the following disclaimer in the
//       documentation and/or other materials provided with the distribution.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
// ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
// LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
// CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
// SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
// INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
// CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
// ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
// POSSIBILITY OF SUCH DAMAGE.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Midi
{
    /// <summary>
    /// MIDI Control, used in Control Change messages.
    /// </summary>
    /// <remarks>
    /// <para>In MIDI, Control Change messages are used to influence various auxiliary "controls"
    /// on a device, such as knobs, levers, and pedals.  Controls are specified with
    /// integers in [0..127].  This enum provides an incomplete list of controls, because
    /// most controls are too obscure to document effetively here.  Even for the ones listed
    /// here, the details of how the value is interpreted are arcane.  Please see the MIDI spec for
    /// details.</para>
    /// <para>The most commonly used control is SustainPedal, which is considered off when &lt; 64,
    /// on when &gt; 64.</para>
    /// <para>This enum has extension methods, such as <see cref="ControlExtensionMethods.Name"/>
    /// and <see cref="ControlExtensionMethods.IsValid"/>, defined in
    /// <see cref="ControlExtensionMethods"/>.</para>
    /// </remarks>
    public enum Control
    {
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        ModulationWheel = 1,
        /// <summary>General MIDI Control--Modwheel.</summary>
        CC1 = 1,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC2 = 2,  
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC3 = 3,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC4 = 4,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC5 = 5,
        /// <summary>General MIDI Control--DataEntryMSB</summary>
        DataEntryMSB = 6,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        CC6 = 6,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        Volume = 7,
        /// <summary>General MIDI Control--Volume.</summary>
        CC7 = 7,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC8 = 8,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC9 = 9,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        Pan = 10,
        /// <summary>General MIDI Control--Pan.</summary>
        CC10 = 10,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        Expression = 11,
        /// <summary>General MIDI Control--Expression.</summary>
        CC11 = 11,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC12 = 12,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC13 = 13,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC14 = 14,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC15 = 15,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC16 = 16,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC17 = 17,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC18 = 18,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC19 = 19,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC20 = 20,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC21 = 21,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC22 = 22,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC23 = 23,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC24 = 24,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC25 = 25,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC26 = 26,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC27 = 27,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC28 = 28,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC29 = 29,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC30 = 30,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC31 = 31,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC32 = 32,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC33 = 33,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC34 = 34,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC35 = 35,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC36 = 36,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC37 = 37,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        DataEntryLSB = 38,
        /// <summary>General MIDI Control--DataEntryLSB.</summary>
        CC38 = 38,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC39 = 39,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC40 = 40,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC41 = 41,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC42 = 42,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC43 = 43,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC44 = 44,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC45 = 45,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC46 = 46,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC47 = 47,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC48 = 48,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC49 = 49,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC50 = 50,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC51 = 51,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC52 = 52,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC53 = 53,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC54 = 54,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC55 = 55,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC56 = 56,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC57 = 57,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC58 = 58,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC59 = 59,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC60 = 60,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC61 = 61,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC62 = 62,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC63 = 63,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        SustainPedal = 64,
        /// <summary>General MIDI Control--SustainPedal.</summary>
        CC64 = 64,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC65 = 65,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC66 = 66,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC67 = 67,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC68 = 68,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC69 = 69,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC70 = 70,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC71 = 71,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC72 = 72,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC73 = 73,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC74 = 74,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC75 = 75,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC76 = 76,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC77 = 77,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC78 = 78,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC79 = 79,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC80 = 80,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC81 = 81,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC82 = 82,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC83 = 83,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC84 = 84,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC85 = 85,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC86 = 86,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC87 = 87,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC88 = 88,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC89 = 89,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC90 = 90,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        ReverbLevel = 91,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        CC91 = 91,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        TremoloLevel = 92,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        CC92 = 92,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        ChorusLevel = 93,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        CC93 = 93,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        CelesteLevel = 94,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        CC94 = 94,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        PhaserLevel = 95,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        CC95 = 95,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC96 = 96,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC97 = 97,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        NonRegisteredParameterLSB = 98,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        CC98 = 98,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        NonRegisteredParameterMSB = 99,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        CC99 = 99,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        RegisteredParameterNumberLSB = 100,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        CC100 = 100,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        RegisteredParameterNumberMSB = 101,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        CC101 = 101,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC102 = 102,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC103 = 103,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC104 = 104,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC105 = 105,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC106 = 106,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC107 = 107,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC108 = 108,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC109 = 109,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC110 = 110,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC111 = 111,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC112 = 112,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC113 = 113,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC114 = 114,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC115 = 115,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC116 = 116,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC117 = 117,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC118 = 118,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC119 = 119,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC120 = 120,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        AllControllersOff = 121,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        CC121 = 121,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        AllNotesOff = 123,
        /// <summary>General MIDI Control--See MIDI spec for details.</summary>
        CC123 = 123,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC124 = 124,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC125 = 125,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC126 = 126,
        /// <summary>Not a part of General MIDI Control--See your device manual details.</summary>
        CC127 = 127
    }

    /// <summary>
    /// Extension methods for the Control enum.
    /// </summary>
    /// Be sure to "using midi" if you want to use these as extension methods.
    public static class ControlExtensionMethods
    {
        /// <summary>
        /// Returns true if the specified control is valid.
        /// </summary>
        /// <param name="control">The Control to test.</param>
        public static bool IsValid(this Control control)
        {
            return (int)control >= 0 && (int)control < 128;
        }

        /// <summary>
        /// Throws an exception if control is not valid.
        /// </summary>
        /// <param name="control">The control to validate.</param>
        /// <exception cref="ArgumentOutOfRangeException">The control is out-of-range.</exception>
        public static void Validate(this Control control)
        {
            if (!control.IsValid())
            {
                throw new ArgumentOutOfRangeException("Control out of range");
            }
        }

        /// <summary>
        /// Table of control names.
        /// </summary>
        private static Dictionary<int, string> ControlNames = new Dictionary<int, string>
        {
            {1, "Modulation wheel"},
            {6, "Data Entry MSB"},
            {7, "Volume"},
            {10, "Pan"},
            {11, "Expression"},
            {38, "Data Entry LSB"},
            {64, "Sustain pedal"},
            {91, "Reverb level"},
            {92, "Tremolo level"},
            {93, "Chorus level"},
            {94, "Celeste level"},
            {95, "Phaser level"},
            {98, "Non-registered Parameter LSB"},
            {99, "Non-registered Parameter MSB"},
            {100, "Registered Parameter Number LSB"},
            {101, "Registered Parameter Number MSB"},
            {121, "All controllers off"},
            {123, "All notes off"}
        };

        /// <summary>
        /// Returns the human-readable name of a MIDI control.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <exception cref="ArgumentOutOfRangeException">The control is out-of-range.</exception>
        public static string Name(this Control control)
        {
            control.Validate();
            if (ControlNames.ContainsKey((int)control))
            {
                return ControlNames[(int)control];
            }
            else
            {
                return "Other Control (see MIDI spec for details).";
            }
        }
    }
}
