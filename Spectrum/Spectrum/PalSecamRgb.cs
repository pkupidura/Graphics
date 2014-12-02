﻿namespace Spectrum {
    class PalSecamRgb : ColourSpace {
        public PalSecamRgb()
        {
            ConversionMatrix = new Matrix3X3(
                3.0628971, -1.3931791, -0.4757517, 
                -0.9692660, 1.8760108, 0.0415560, 
                0.0678775, -0.2288548, 1.0693490);
        }
    }
}
