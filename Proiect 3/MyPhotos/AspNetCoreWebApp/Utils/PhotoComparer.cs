using ServiceReferencePhoto;
using System.Collections.Generic;

namespace AspNetCoreWebApp
{
    public class PhotoComparer : IEqualityComparer<Photo>
    {
        public bool Equals(Photo p1, Photo p2)
        {
            if (p1.PhotoId == p2.PhotoId)
            {
                return true;
            }
            return false;
        }
        public int GetHashCode(Photo obj)
        {
            return obj.PhotoId.GetHashCode();
        }
    }
}
