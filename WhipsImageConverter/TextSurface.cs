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

        public TextSurface(string surfaceName, Vector2 textureAndSurfaceSize)
        {
            TextureSize = textureAndSurfaceSize;
            SurfaceSize = textureAndSurfaceSize;
            SurfaceName = surfaceName;

        }

        public TextSurface(string surfaceName, Vector2 textureSize, Vector2 surfaceSize)
        {
            TextureSize = textureSize;
            SurfaceSize = surfaceSize;
            SurfaceName = surfaceName;
        }
    }
}
