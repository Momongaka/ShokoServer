﻿using FluentNHibernate.Mapping;
using Shoko.Models.Server;

namespace Shoko.Server.Mappings
{
    public class CharacterMap : ClassMap<Character>
    {
        public CharacterMap()
        {
            Table("Character");
            Not.LazyLoad();
            Id(x => x.CharacterID);
            Map(x => x.AniDBID).Not.Nullable();
            Map(x => x.Name).Not.Nullable();
            Map(x => x.AlternateName);
            Map(x => x.Description).CustomType("StringClob").CustomSqlType("nvarchar(max)");
            Map(x => x.ImagePath);
        }
    }
}