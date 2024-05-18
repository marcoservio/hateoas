using System.Collections.Generic;

namespace Jisko.HATEOAS.Hypermedia.Abstract
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
