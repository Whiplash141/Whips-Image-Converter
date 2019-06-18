using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WhipsImageConverter
{
    public class TextSurfaceProvider
    {
        public static TextSurfaceProvider Lcd = new TextSurfaceProvider("LCD Panel");
        public static TextSurfaceProvider WideLcd = new TextSurfaceProvider("Wide LCD Panel");
        public static TextSurfaceProvider CornerLcd = new TextSurfaceProvider("Corner LCD");
        public static TextSurfaceProvider TextPanel = new TextSurfaceProvider("Text Panel");
        public static TextSurfaceProvider LargeProgrammableBlock = new TextSurfaceProvider("Large Programmable Block", 2);
        public static TextSurfaceProvider SmallProgrammableBlock = new TextSurfaceProvider("Small Programmable Block", 2);
        public static TextSurfaceProvider ConsoleBlock = new TextSurfaceProvider("Console Block", 4);
        public static TextSurfaceProvider FighterCockpit = new TextSurfaceProvider("Fighter Cockpit", 6);
        public static TextSurfaceProvider LargeCockpit = new TextSurfaceProvider("Large Cockpit", 6);
        public static TextSurfaceProvider SmallCockpit = new TextSurfaceProvider("Small Cockpit", 4);
        public static TextSurfaceProvider LargeIndustrialCockpit = new TextSurfaceProvider("Large Industrial Cockpit", 6);
        public static TextSurfaceProvider SmallIndustrialCockpit = new TextSurfaceProvider("Small Industrial Cockpit", 5);
        public static TextSurfaceProvider LargeFlightSeat = new TextSurfaceProvider("Flight Seat");
        public static TextSurfaceProvider LargeControlStation = new TextSurfaceProvider("Control Station");


        public static List<TextSurfaceProvider> TextSurfaceProviders = new List<TextSurfaceProvider>();

        public readonly string BlockName;
        public readonly TextSurface[] TextSurfaces;

        public TextSurfaceProvider(string blockName, int surfaceCount = 1)
        {
            BlockName = blockName;
            TextSurfaces = new TextSurface[surfaceCount];
        }

        static TextSurfaceProvider()
        {
            Vector2 standardSize = new Vector2(512, 512);

            Lcd.TextSurfaces[0] = new TextSurface("ScreenArea", standardSize);
            WideLcd.TextSurfaces[0] = new TextSurface("ScreenArea", new Vector2(1024, 512));
            CornerLcd.TextSurfaces[0] = new TextSurface("ScreenArea", standardSize);
            TextPanel.TextSurfaces[0] = new TextSurface("ScreenArea", standardSize, new Vector2(512f, 307.2f));

            LargeProgrammableBlock.TextSurfaces[0] = new TextSurface("Large Display", standardSize, new Vector2(512f, 320f));
            LargeProgrammableBlock.TextSurfaces[1] = new TextSurface("Keyboard", standardSize, new Vector2(512f, 204.8f));

            SmallProgrammableBlock.TextSurfaces[0] = new TextSurface("Large Display", standardSize * 0.5f, standardSize * 0.5f);
            SmallProgrammableBlock.TextSurfaces[1] = new TextSurface("Keyboard", new Vector2(256f, 128f), new Vector2(256f, 90.09091f));

            ConsoleBlock.TextSurfaces[0] = new TextSurface("Projection Area", new Vector2(512f, 512f), new Vector2(512f, 512f));
            ConsoleBlock.TextSurfaces[1] = new TextSurface("Large Display", new Vector2(256f, 256f), new Vector2(256f, 175f));
            ConsoleBlock.TextSurfaces[2] = new TextSurface("Numpad", new Vector2(128f, 128f), new Vector2(85.33334f, 128f));
            ConsoleBlock.TextSurfaces[3] = new TextSurface("Keyboard", new Vector2(256f, 128f), new Vector2(256f, 128f));

            FighterCockpit.TextSurfaces[0] = new TextSurface("Top Center Screen", new Vector2(256f, 256f), new Vector2(256f, 153.6f));
            FighterCockpit.TextSurfaces[1] = new TextSurface("Top Left Screen", new Vector2(128f, 128f), new Vector2(128f, 85.33334f));
            FighterCockpit.TextSurfaces[2] = new TextSurface("Top Right Screen", new Vector2(128f, 128f), new Vector2(128f, 85.33334f));
            FighterCockpit.TextSurfaces[3] = new TextSurface("Keyboard", new Vector2(256f, 128f), new Vector2(256f, 109.7143f));
            FighterCockpit.TextSurfaces[4] = new TextSurface("Bottom Center Screen", new Vector2(256f, 256f), new Vector2(204.8f, 256f));
            FighterCockpit.TextSurfaces[5] = new TextSurface("Numpad", new Vector2(128f, 128f), new Vector2(102.4f, 128f));

            LargeCockpit.TextSurfaces[0] = new TextSurface("Top Center Screen", new Vector2(256f, 256f), new Vector2(256f, 177.2308f));
            LargeCockpit.TextSurfaces[1] = new TextSurface("Top Left Screen", new Vector2(256f, 256f), new Vector2(256f, 192f));
            LargeCockpit.TextSurfaces[2] = new TextSurface("Top Right Screen", new Vector2(256f, 256f), new Vector2(256f, 192f));
            LargeCockpit.TextSurfaces[3] = new TextSurface("Keyboard", new Vector2(256f, 256f), new Vector2(256f, 146.2857f));
            LargeCockpit.TextSurfaces[4] = new TextSurface("Bottom Left Screen", new Vector2(256f, 256f), new Vector2(256f, 199.1111f));
            LargeCockpit.TextSurfaces[5] = new TextSurface("Bottom Right Screen", new Vector2(256f, 256f), new Vector2(256f, 199.1111f));

            SmallCockpit.TextSurfaces[0] = new TextSurface("Top Center Screen", new Vector2(256f, 256f), new Vector2(256f, 256f));
            SmallCockpit.TextSurfaces[1] = new TextSurface("Top Left Screen", new Vector2(256f, 256f), new Vector2(256f, 192f));
            SmallCockpit.TextSurfaces[2] = new TextSurface("Top Right Screen", new Vector2(256f, 256f), new Vector2(256f, 192f));
            SmallCockpit.TextSurfaces[3] = new TextSurface("Keyboard", new Vector2(256f, 256f), new Vector2(256f, 139.6364f));

            LargeIndustrialCockpit.TextSurfaces[0] = new TextSurface("Large Display", new Vector2(256f, 256f), new Vector2(256f, 153.6f));
            LargeIndustrialCockpit.TextSurfaces[1] = new TextSurface("Top Left Screen", new Vector2(256f, 256f), new Vector2(256f, 179.2f));
            LargeIndustrialCockpit.TextSurfaces[2] = new TextSurface("Top Center Screen", new Vector2(256f, 256f), new Vector2(256f, 179.2f));
            LargeIndustrialCockpit.TextSurfaces[3] = new TextSurface("Top Right Screen", new Vector2(256f, 256f), new Vector2(256f, 153.6f));
            LargeIndustrialCockpit.TextSurfaces[4] = new TextSurface("Keyboard", new Vector2(256f, 256f), new Vector2(256f, 153.6f));
            LargeIndustrialCockpit.TextSurfaces[5] = new TextSurface("Numpad", new Vector2(256f, 256f), new Vector2(204.8f, 256f));

            SmallIndustrialCockpit.TextSurfaces[0] = new TextSurface("Top Left Screen", new Vector2(256f, 256f), new Vector2(256f, 182.8571f));
            SmallIndustrialCockpit.TextSurfaces[1] = new TextSurface("Top Center Screen", new Vector2(256f, 256f), new Vector2(256f, 170.6667f));
            SmallIndustrialCockpit.TextSurfaces[2] = new TextSurface("Top Right Screen", new Vector2(256f, 256f), new Vector2(256f, 182.8571f));
            SmallIndustrialCockpit.TextSurfaces[3] = new TextSurface("Keyboard", new Vector2(256f, 128f), new Vector2(256f, 128f));
            SmallIndustrialCockpit.TextSurfaces[4] = new TextSurface("Numpad", new Vector2(128f, 128f), new Vector2(106.6667f, 128f));

            LargeFlightSeat.TextSurfaces[0] = new TextSurface("Large Display", new Vector2(512,128), new Vector2(512, 113.7778f));
            LargeControlStation.TextSurfaces[0] = new TextSurface("Large Display", new Vector2(512, 512), new Vector2(512, 307.2f));

            TextSurfaceProviders = new List<TextSurfaceProvider>()
            {
                Lcd,
                WideLcd,
                CornerLcd,
                TextPanel,
                LargeProgrammableBlock,
                SmallProgrammableBlock,
                ConsoleBlock,
                FighterCockpit,
                LargeCockpit,
                SmallCockpit,
                LargeIndustrialCockpit,
                SmallIndustrialCockpit,
                LargeFlightSeat,
                LargeControlStation,
            };
        }
    }
}
