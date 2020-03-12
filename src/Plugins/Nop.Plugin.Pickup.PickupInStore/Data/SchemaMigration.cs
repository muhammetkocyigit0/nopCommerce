﻿using FluentMigrator;
using Nop.Data.Migrations;
using Nop.Plugin.Pickup.PickupInStore.Domain;

namespace Nop.Plugin.Pickup.PickupInStore.Data
{
    [NopMigration("2020/02/03 09:30:01.429")]
    [Tags(NopMigrationTags.SCHEMA)]
    public class SchemaMigration : AutoReversingMigration
    {
        protected IMigrationManager _migrationManager;

        public SchemaMigration(IMigrationManager migrationManager)
        {
            _migrationManager = migrationManager;
        }

        public override void Up()
        {
            _migrationManager.BuildTable<StorePickupPoint>(Create);
        }
    }
}