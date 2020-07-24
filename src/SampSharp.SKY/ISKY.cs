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

using SampSharp.GameMode;
using SampSharp.GameMode.World;
using SampSharp.GameMode.Display;

using SampSharp.SKY.Definitions;

namespace SampSharp.SKY
{
    /// <summary>
    /// Represents a service for control the SKY.
    /// </summary>
    public interface ISky : IService
    {
        void SpawnPlayerForWorld(BasePlayer player);
        bool FreezeSyncPacket(BasePlayer player, SyncType type = SyncType.E_PLAYER_SYNC, bool toggle = false);
        bool SetFakeHealth(BasePlayer player, int health);
        bool SetFakeArmour(BasePlayer player, int amount);
        bool SetFakeFacingAngle(BasePlayer player, float angle = 0x7FFFFFFFf);
        void SetKnifeSync(int toggle);
        bool SendDeath(BasePlayer player);
        bool SetLastAnimationData(BasePlayer player, int data);
        bool SendLastSyncPacket(BasePlayer player, BasePlayer toplayer, SyncType type = SyncType.E_PLAYER_SYNC, int animation = 0);
        bool ClearAnimationsForPlayer(BasePlayer player, BasePlayer forplayer);
        void SetDisableSyncBugs(int toggle);
        bool SetKeySyncBlocked(BasePlayer player, int toggle);
        bool TextDrawSetStrForPlayer(TextDraw textdraw, BasePlayer player, string str);
        bool TextDrawSetPosition(TextDraw textdraw, Vector2 position);
        bool PlayerTextDrawSetPosition(BasePlayer player, PlayerTextDraw textdraw, Vector2 position);
    }
}
