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
    /// Represents a service for control the SKY.
    /// </summary>
    public class SkyService : ISkyService
    {
        private readonly SkyServiceNative _native;

        /// <summary>
        /// Initializes a new instance of the <see cref="SkyService" /> class.
        /// </summary>
        public SkyService(INativeProxy<SkyServiceNative> nativeProxy)
        {
            _native = nativeProxy.Instance;
        }

        #region Others

        /// <inheritdoc />
        public void SpawnPlayerForWorld(EntityId player)
        {
            if (!player.IsOfType(SampEntities.PlayerType))
                throw new InvalidEntityArgumentException(nameof(player), SampEntities.PlayerType);

            _native.SpawnPlayerForWorld(player.Handle);
        }
        /// <inheritdoc />
        public bool FreezeSyncPacket(EntityId player, SyncType type = SyncType.E_PLAYER_SYNC, bool toggle = false)
        {
            if (!player.IsOfType(SampEntities.PlayerType))
                throw new InvalidEntityArgumentException(nameof(player), SampEntities.PlayerType);

            var success = _native.FreezeSyncPacket(player, (int)type, toggle);
            return success;
        }
        /// <inheritdoc />
        public bool SetFakeHealth(EntityId player, int health)
        {
            if (!player.IsOfType(SampEntities.PlayerType))
                throw new InvalidEntityArgumentException(nameof(player), SampEntities.PlayerType);

            var success = _native.SetFakeHealth(player, health);
            return success;
        }
        /// <inheritdoc />
        public bool SetFakeArmour(EntityId player, int amount)
        {
            if (!player.IsOfType(SampEntities.PlayerType))
                throw new InvalidEntityArgumentException(nameof(player), SampEntities.PlayerType);

            var success = _native.SetFakeArmour(player, amount);
            return success;
        }
        /// <inheritdoc />
        public bool SetFakeFacingAngle(EntityId player, float angle = 0x7FFFFFFFf)
        {
            if (!player.IsOfType(SampEntities.PlayerType))
                throw new InvalidEntityArgumentException(nameof(player), SampEntities.PlayerType);

            var success = _native.SetFakeFacingAngle(player.Handle, angle);
            return success;
        }
        /// <inheritdoc />
        public void SetKnifeSync(int toggle)
        {
            _native.SetKnifeSync(toggle);
        }
        /// <inheritdoc />
        public bool SendDeath(EntityId player)
        {
            if (!player.IsOfType(SampEntities.PlayerType))
                throw new InvalidEntityArgumentException(nameof(player), SampEntities.PlayerType);

            var success = _native.SendDeath(player);
            return success;
        }
        /// <inheritdoc />
        public bool SetLastAnimationData(EntityId player, int data)
        {
            if (!player.IsOfType(SampEntities.PlayerType))
                throw new InvalidEntityArgumentException(nameof(player), SampEntities.PlayerType);

            var success = _native.SetLastAnimationData(player, data);
            return success;
        }
        /// <inheritdoc />
        public bool SendLastSyncPacket(EntityId player, EntityId toplayer, SyncType type = SyncType.E_PLAYER_SYNC, int animation = 0)
        {
            if (!player.IsOfType(SampEntities.PlayerType))
                throw new InvalidEntityArgumentException(nameof(player), SampEntities.PlayerType);

            if (!toplayer.IsOfType(SampEntities.PlayerType))
                throw new InvalidEntityArgumentException(nameof(toplayer), SampEntities.PlayerType);

            var success = _native.SendLastSyncPacket(player, toplayer, (int)type, animation);
            return success;
        }
        /// <inheritdoc />
        public bool ClearAnimationsForPlayer(EntityId player, EntityId forplayer)
        {
            if (!player.IsOfType(SampEntities.PlayerType))
                throw new InvalidEntityArgumentException(nameof(player), SampEntities.PlayerType);

            if (!forplayer.IsOfType(SampEntities.PlayerType))
                throw new InvalidEntityArgumentException(nameof(forplayer), SampEntities.PlayerType);

            var success = _native.ClearAnimationsForPlayer(player, forplayer);
            return success;
        }
        /// <inheritdoc />
        public void SetDisableSyncBugs(int toggle)
        {
            _native.SetDisableSyncBugs(toggle);
        }
        /// <inheritdoc />
        public bool SetInfiniteAmmoSync(EntityId player, int toggle)
        {
            if (!player.IsOfType(SampEntities.PlayerType))
                throw new InvalidEntityArgumentException(nameof(player), SampEntities.PlayerType);

            var success = _native.SetInfiniteAmmoSync(player, toggle);
            return success;
        }
        /// <inheritdoc />
        public bool SetKeySyncBlocked(EntityId player, int toggle)
        {
            if (!player.IsOfType(SampEntities.PlayerType))
                throw new InvalidEntityArgumentException(nameof(player), SampEntities.PlayerType);

            var success = _native.SetKeySyncBlocked(player, toggle);
            return success;
        }
        #endregion

        #region TextDraw

        /// <inheritdoc />
        public bool TextDrawSetStrForPlayer(TextDraw textdraw, EntityId player, string str)
        {
            if (!player.IsOfType(SampEntities.PlayerType))
                throw new InvalidEntityArgumentException(nameof(player), SampEntities.PlayerType);

            if (textdraw.Entity.Handle == NativeTextDraw.InvalidId)
                throw new EntityCreationException();

            var success = _native.TextDrawSetStrForPlayer(textdraw.Entity.Handle, player.Handle, str);
            return success;
        }

        /// <inheritdoc />
        public bool TextDrawSetPosition(TextDraw textdraw, Vector2 position)
        {
            if (textdraw.Entity.Handle == NativeTextDraw.InvalidId)
                throw new EntityCreationException();

            var success = _native.TextDrawSetPosition(textdraw.Entity.Handle, position.X, position.Y);

            return success;
        }

        /// <inheritdoc />
        public bool PlayerTextDrawSetPosition(EntityId player, PlayerTextDraw textdraw, Vector2 position)
        {
            if (!player.IsOfType(SampEntities.PlayerType))
                throw new InvalidEntityArgumentException(nameof(player), SampEntities.PlayerType);

            int id = textdraw.Entity / SampLimits.MaxPlayers;

            if (id == NativePlayerTextDraw.InvalidId)
                throw new EntityCreationException();

            var success = _native.PlayerTextDrawSetPosition(player, id, position.X, position.Y);
            return success;
        }
        #endregion
    }
}
