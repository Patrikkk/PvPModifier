﻿using System;
using System.IO;
using PvPModifier.Variables;

namespace PvPModifier.Network.Packets {
    public class PlayerUpdateArgs : EventArgs {
        public PvPPlayer Player { get; set; }

        public int PlayerAction { get; set; }
        public int Pulley { get; set; }
        public int SelectedSlot { get; set; }

        public bool ExtractData(MemoryStream data, PvPPlayer player, out PlayerUpdateArgs arg) {
            data.ReadByte();

            arg = new PlayerUpdateArgs {
                Player = player,
                PlayerAction = data.ReadByte(),
                Pulley = data.ReadByte(),
                SelectedSlot = data.ReadByte()
            };

            return true;
        }
    }
}
