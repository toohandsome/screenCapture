using ImageProcessor;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _SCREEN_CAPTURE
{
    public class ImageUtil
    {
        public static void test(Bitmap b) {

            //using (Image image = Image.Load("foo.jpg"))
            //{
            //    // Resize the image in place and return it for chaining.
            //    // 'x' signifies the current image processing context.
            //    image.Mutate(x => x.Resize(image.Width / 2, image.Height / 2));
            //    image.Mutate(x => x.ApplyProcessor);

            //    // The library automatically picks an encoder based on the file extensions then encodes and write the data to disk.
            //    image.Save("bar.jpg");
            //} // Dispose - releasing memory into a memory pool ready for the next image you wish to process.

            ImageFactory imageFactory = new ImageFactory();
            imageFactory.Load(b).Gamma(3);

        }
    }
}
