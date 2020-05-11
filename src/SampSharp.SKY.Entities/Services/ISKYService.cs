// SampSharp.SKY.Entities
// Copyright 2020 BlasterDv
// 
// Licensed under the Apache License, Version 2.0 (the "License");
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

using SampSharp.Entities;
using SampSharp.Entities.SAMP;

namespace SampSharp.SKY.Entities
{
    /// <summary>
    ///     Provides functionality controlling the SKY.
    /// </summary>
    public interface ISkyService
    {
        void SpawnPlayerForWorld(EntityId player);
        bool FreezeSyncPacket(EntityId player, SyncType type = SyncType.E_PLAYER_SYNC, bool toggle = false);
        bool SetFakeHealth(EntityId player, int health);
        bool SetFakeArmour(EntityId player, int amount);
        bool SetFakeFacingAngle(EntityId player, float angle = 0x7FFFFFFFf);
        void SetKnifeSync(int toggle);
        bool SendDeath(EntityId player);
        bool SetLastAnimationData(EntityId player, int data);
        bool SendLastSyncPacket(EntityId player, EntityId toplayer, SyncType type = SyncType.E_PLAYER_SYNC, int animation = 0);
        bool ClearAnimationsForPlayer(EntityId player, EntityId forplayer);
        void SetDisableSyncBugs(int toggle);
        bool SetInfiniteAmmoSync(EntityId player, int toggle);
        bool SetKeySyncBlocked(EntityId player, int toggle);
        /// <summary>
        /// Set the string of a TextDraw per-player
        /// </summary>
        /// <param name="textdraw">The Textdraw.</param>
        /// <param name="player">The player.</param>
        /// <param name="str">The text.</param>
        /// <returns>True on success, False otherwise.</returns>
        bool TextDrawSetStrForPlayer(EntityId textdraw, EntityId player, string str);
        bool TextDrawSetPosition(TextDraw textdraw, Vector2 position);
        bool PlayerTextDrawSetPosition(Player player, PlayerTextDraw textdraw, Vector2 position);
    }
}