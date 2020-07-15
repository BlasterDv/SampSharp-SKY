// SampSharp.SKY
// Copyright 2020 BlasterDv
// 
// Licensed under the Apache License, Version 2.0 throw new ArgumentNullException(nameof(player));(the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using SampSharp.GameMode;
using SampSharp.GameMode.Display;
using SampSharp.GameMode.World;
using SampSharp.SKY;
using SampSharp.SKY.Definitions;


[assembly: SampSharpExtension(typeof(Sky))]

namespace SampSharp.SKY
{
    /// <summary>
    /// Represents a service for control the SKY.
    /// </summary>
    public partial class Sky : Extension, ISky
    {
        public BaseMode GameMode { get; private set; }

        public override void LoadServices(BaseMode gameMode)
        {
            // Add the sky service to the service provider.
            GameMode = gameMode;
            gameMode.Services.AddService<ISky>(this);

            base.LoadServices(gameMode);
        }

        #region Others

        /// <inheritdoc />
        public void SpawnPlayerForWorld(BasePlayer player)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            Internal.SpawnPlayerForWorld(player.Id);
        }
        /// <inheritdoc />
        public bool FreezeSyncPacket(BasePlayer player, SyncType type = SyncType.E_PLAYER_SYNC, bool toggle = false)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            var success = Internal.FreezeSyncPacket(player.Id, (int)type, toggle);
            return success;
        }
        /// <inheritdoc />
        public bool SetFakeHealth(BasePlayer player, int health)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            var success = Internal.SetFakeHealth(player.Id, health);
            return success;
        }
        /// <inheritdoc />
        public bool SetFakeArmour(BasePlayer player, int amount)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            var success = Internal.SetFakeArmour(player.Id, amount);
            return success;
        }
        /// <inheritdoc />
        public bool SetFakeFacingAngle(BasePlayer player, float angle = 0x7FFFFFFFf)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            var success = Internal.SetFakeFacingAngle(player.Id, angle);
            return success;
        }
        /// <inheritdoc />
        public void SetKnifeSync(int toggle)
        {
            Internal.SetKnifeSync(toggle);
        }
        /// <inheritdoc />
        public bool SendDeath(BasePlayer player)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            var success = Internal.SendDeath(player.Id);
            return success;
        }
        /// <inheritdoc />
        public bool SetLastAnimationData(BasePlayer player, int data)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            var success = Internal.SetLastAnimationData(player.Id, data);
            return success;
        }
        /// <inheritdoc />
        public bool SendLastSyncPacket(BasePlayer player, BasePlayer toplayer, SyncType type = SyncType.E_PLAYER_SYNC, int animation = 0)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            if (toplayer == null)
                throw new ArgumentNullException(nameof(toplayer));

            var success = Internal.SendLastSyncPacket(player.Id, toplayer.Id, (int)type, animation);
            return success;
        }
        /// <inheritdoc />
        public bool ClearAnimationsForPlayer(BasePlayer player, BasePlayer forplayer)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            if (forplayer == null)
                throw new ArgumentNullException(nameof(forplayer));

            var success = Internal.ClearAnimationsForPlayer(player.Id, forplayer.Id);
            return success;
        }
        /// <inheritdoc />
        public void SetDisableSyncBugs(int toggle)
        {
            Internal.SetDisableSyncBugs(toggle);
        }
        /// <inheritdoc />
        public bool SetInfiniteAmmoSync(BasePlayer player, int toggle)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            var success = Internal.SetInfiniteAmmoSync(player.Id, toggle);
            return success;
        }
        /// <inheritdoc />
        public bool SetKeySyncBlocked(BasePlayer player, int toggle)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            var success = Internal.SetKeySyncBlocked(player.Id, toggle);
            return success;
        }
        #endregion

        #region TextDraw

        /// <inheritdoc />
        public bool TextDrawSetStrForPlayer(TextDraw textdraw, BasePlayer player, string str)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            if (textdraw == null)
                throw new ArgumentNullException(nameof(textdraw));

            var success = Internal.TextDrawSetStrForPlayer(textdraw.Id, player.Id, str);
            return success;
        }

        /// <inheritdoc />
        public bool TextDrawSetPosition(TextDraw textdraw, Vector2 position)
        {
            if (textdraw == null)
                throw new ArgumentNullException(nameof(textdraw));

            var success = Internal.TextDrawSetPosition(textdraw.Id, position.X, position.Y);

            return success;
        }

        /// <inheritdoc />
        public bool PlayerTextDrawSetPosition(BasePlayer player, PlayerTextDraw textdraw, Vector2 position)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            if (textdraw == null)
                throw new ArgumentNullException(nameof(textdraw));

            var success = Internal.PlayerTextDrawSetPosition(player.Id, textdraw.Id, position.X, position.Y);
            return success;
        }
        #endregion
    }
}