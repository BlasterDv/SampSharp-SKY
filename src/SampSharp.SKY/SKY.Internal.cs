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

using SampSharp.Core.Natives.NativeObjects;

namespace SampSharp.SKY
{
    public partial class Sky
    {
        protected static SkyInternal Internal;

        static Sky()
        {
            Internal = NativeObjectProxyFactory.CreateInstance<SkyInternal>();
        }

        public class SkyInternal
        {
            #region ALL
            [NativeMethod]
            public virtual void SpawnPlayerForWorld(int playerid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual bool FreezeSyncPacket(int playerId, int type, bool toggle)
            {
                throw new NativeNotImplementedException();
            }
            // Set the HP bar (warning: affects GetPlayerHealth)
            [NativeMethod]
            public virtual bool SetFakeHealth(int playerId, int health)
            {
                throw new NativeNotImplementedException();

            }
            // Set the armour bar (warning: affects GetPlayerArmour)
            [NativeMethod]
            public virtual bool SetFakeArmour(int playerId, int armour)
            {
                throw new NativeNotImplementedException();
            }
            // Force a specific facing angle to sync for other players
            [NativeMethod]
            public virtual bool SetFakeFacingAngle(int playerId, float angle)
            {
                throw new NativeNotImplementedException();
            }
            // Disable stealth-knife sync (only the player doing it will see it happen)
            [NativeMethod]
            public virtual void SetKnifeSync(int toggle)
            {
                throw new NativeNotImplementedException();
            }
            // Make a player appear dead for other players
            [NativeMethod]
            public virtual bool SendDeath(int playerid)
            {
                throw new NativeNotImplementedException();
            }
            // Set the last animation data
            [NativeMethod]
            public virtual bool SetLastAnimationData(int playerid, int data)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual bool SendLastSyncPacket(int playerid, int toplayerid, int type, int animation)
            {
                throw new NativeNotImplementedException();
            }
            // Clear animations for another player only
            [NativeMethod]
            public virtual bool ClearAnimationsForPlayer(int playerId, int forplayerId)
            {
                throw new NativeNotImplementedException();
            }
            // Disable infinity ammo bugs and other bugs (some bugs still work)
            [NativeMethod]
            public virtual void SetDisableSyncBugs(int toggle)
            {
                throw new NativeNotImplementedException();
            }
            // Make the weapon state always synced as WEAPONSTATE_MORE_BULLETS
            [NativeMethod]
            public virtual bool SetInfiniteAmmoSync(int playerid, int toggle)
            {
                throw new NativeNotImplementedException();
            }
            // Stop syncing keys for a player
            [NativeMethod]
            public virtual bool SetKeySyncBlocked(int playerid, int toggle)
            {
                throw new NativeNotImplementedException();
            }
            // Same as YSF (renamed to avoid problems)
            [NativeMethod]
            public virtual bool TextDrawSetPosition(int textdrawId, float x, float y)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual bool PlayerTextDrawSetPosition(int playerId, int textdrawId, float x, float y)
            {
                throw new NativeNotImplementedException();
            }
            // Set the string of a TextDraw per-player
            [NativeMethod]
            public virtual bool TextDrawSetStrForPlayer(int text, int playerId, string strinG)
            {
                throw new NativeNotImplementedException();
            }
            #endregion
        }
    }
}