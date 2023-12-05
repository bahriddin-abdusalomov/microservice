using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accommodation.Domain.Exceptions.Images;

public class ImageNotFoundException : NotFoundException
{
    public ImageNotFoundException()
    {
        Message = "Image not found !";
    }
}
