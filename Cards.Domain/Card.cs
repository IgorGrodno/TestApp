using System;

namespace Cards.Domain
{
    public class Card
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid PictureId { get; set; }

    }
}
