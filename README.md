# SampSharp SKY

Wrapper of the SKY plugin for [SampSharp]

[SampSharp]:https://github.com/ikkentim/SampSharp/

Getting Started
--------------

SampSharp.GameMode
```C#
using SampSharp.GameMode.SAMP.Commands;
using SampSharp.GameMode.World;
using SampSharp.SKY;

namespace Test
{
    public class Commands
    {
        [Command("test")]
        private static void test(BasePlayer player)
        {
            Sky.SendDeath(player);
        }
    }
}
```

SampSharp.Entities
```C#
using SampSharp.Entities;
using SampSharp.Entities.SAMP;
using SampSharp.Entities.SAMP.Commands;
using SampSharp.SKY.Entities;

namespace Test
{
    public class CommandsTest : ISystem
    {
        [PlayerCommand("test")]
        private void test(Player player, ISkyService skyService)
        {
            skyService.SendDeath(player);
        }
    }
}
```
