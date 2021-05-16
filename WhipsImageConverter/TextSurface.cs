using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WhipsImageConverter
{
    public struct TextSurface
    {
        public readonly Vector2 TextureSize;
        public readonly Vector2 SurfaceSize;
        public readonly string SurfaceName;
        public readonly float FontSize;

        public TextSurface(string surfaceName, Vector2 textureAndSurfaceSize, float fontSize = 0.1f)
        {
            TextureSize = textureAndSurfaceSize;
            SurfaceSize = textureAndSurfaceSize;
            SurfaceName = surfaceName;
            FontSize = fontSize;
        }

        public TextSurface(string surfaceName, Vector2 textureSize, Vector2 surfaceSize, float fontSize = 0.1f)
        {
            TextureSize = textureSize;
            SurfaceSize = surfaceSize;
            SurfaceName = surfaceName;
            FontSize = fontSize;
        }
    }
}
