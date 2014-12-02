﻿namespace Spectrum {
    class WideGamutRgb : ColourSpace {
        public WideGamutRgb()
        {
            ConversionMatrix = new Matrix3X3(
                1.4628067, -0.1840623, -0.2743606, 
                -0.5217933, 1.4472381, 0.0677227, 
                0.0349342, -0.0968930, 1.2884099);
        }
    }
}
