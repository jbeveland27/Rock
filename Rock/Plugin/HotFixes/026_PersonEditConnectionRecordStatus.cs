﻿// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//

namespace Rock.Plugin.HotFixes
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Rock.Plugin.Migration" />
    [MigrationNumber( 26, "1.6.3" )]
    public class PersonEditConnectionRecordStatus : Migration
    {
        /// <summary>
        /// The commands to run to migrate plugin to the specific version
        /// </summary>
        public override void Up()
        {
            // Moved to core migration: 201711271827181_V7Rollup

            //            Sql( @"DECLARE @EntityTypeId INT = (
            //		SELECT TOP 1 [Id]
            //		FROM [EntityType]
            //		WHERE [Name] = 'Rock.Model.Block'
            //		)
            //DECLARE @PersonEditBlockId INT = (
            //		SELECT TOP 1 [Id]
            //		FROM [Block]
            //		WHERE [Guid] = '59C7EA79-2073-4EA9-B439-7E74F06E8F5B'
            //		)
            //DECLARE @RockAdminGroupId INT = (
            //		SELECT TOP 1 [Id]
            //		FROM [Group]
            //		WHERE [Guid] = '628C51A8-4613-43ED-A18D-4A6FB999273E'
            //		)
            //DECLARE @Order INT = (
            //		SELECT MAX([Order])
            //		FROM [Auth]
            //		WHERE EntityTypeId = @EntityTypeId
            //			AND EntityId = @PersonEditBlockId
            //			AND [Action] = 'Edit'
            //		)

            //--select * from [Auth] 
            //IF NOT EXISTS (
            //		SELECT *
            //		FROM Auth
            //		WHERE Action = 'EditConnectionStatus'
            //			AND EntityTypeId = @EntityTypeId
            //			AND EntityId = @PersonEditBlockId
            //		)
            //BEGIN
            //	INSERT INTO [Auth] (
            //		EntityTypeid
            //		,EntityId
            //		,[Order]
            //		,[Action]
            //		,AllowOrDeny
            //		,SpecialRole
            //		,GroupId
            //		,PersonAliasId
            //		,[Guid]
            //		)
            //	SELECT EntityTypeid
            //		,EntityId
            //		,[Order]
            //		,'EditConnectionStatus'
            //		,AllowOrDeny
            //		,SpecialRole
            //		,GroupId
            //		,PersonAliasId
            //		,newid()
            //	FROM [Auth]
            //	WHERE EntityTypeId = @EntityTypeId
            //		AND EntityId = @PersonEditBlockId
            //		AND [Action] = 'Edit'

            //	IF @RockAdminGroupId IS NOT NULL
            //	BEGIN
            //		INSERT INTO [dbo].[Auth] (
            //			[EntityTypeId]
            //			,[EntityId]
            //			,[Order]
            //			,[Action]
            //			,[AllowOrDeny]
            //			,[SpecialRole]
            //			,[GroupId]
            //			,[Guid]
            //			)
            //		VALUES (
            //			@EntityTypeId
            //			,@PersonEditBlockId
            //			,@Order + 1
            //			,'EditConnectionStatus'
            //			,'A'
            //			,0
            //			,@RockAdminGroupId
            //			,NEWID()
            //			)
            //	END

            //	INSERT INTO [dbo].[Auth] (
            //		[EntityTypeId]
            //		,[EntityId]
            //		,[Order]
            //		,[Action]
            //		,[AllowOrDeny]
            //		,[SpecialRole]
            //		,[Guid]
            //		)
            //	VALUES (
            //		@EntityTypeId
            //		,@PersonEditBlockId
            //		,@Order + 2
            //		,'EditConnectionStatus'
            //		,'D'
            //		,1
            //		,NEWID()
            //		)
            //END

            //IF NOT EXISTS (
            //		SELECT *
            //		FROM Auth
            //		WHERE Action = 'EditRecordStatus'
            //			AND EntityTypeId = @EntityTypeId
            //			AND EntityId = @PersonEditBlockId
            //		)
            //BEGIN
            //	INSERT INTO [Auth] (
            //		EntityTypeid
            //		,EntityId
            //		,[Order]
            //		,[Action]
            //		,AllowOrDeny
            //		,SpecialRole
            //		,GroupId
            //		,PersonAliasId
            //		,[Guid]
            //		)
            //	SELECT EntityTypeid
            //		,EntityId
            //		,[Order]
            //		,'EditRecordStatus'
            //		,AllowOrDeny
            //		,SpecialRole
            //		,GroupId
            //		,PersonAliasId
            //		,NEWID()
            //	FROM [Auth]
            //	WHERE EntityTypeId = @EntityTypeId
            //		AND EntityId = @PersonEditBlockId
            //		AND [Action] = 'Edit'

            //	IF @RockAdminGroupId IS NOT NULL
            //	BEGIN
            //		INSERT INTO [dbo].[Auth] (
            //			[EntityTypeId]
            //			,[EntityId]
            //			,[Order]
            //			,[Action]
            //			,[AllowOrDeny]
            //			,[SpecialRole]
            //			,[GroupId]
            //			,[Guid]
            //			)
            //		VALUES (
            //			@EntityTypeId
            //			,@PersonEditBlockId
            //			,@Order + 1
            //			,'EditRecordStatus'
            //			,'A'
            //			,0
            //			,@RockAdminGroupId
            //			,NEWID()
            //			)
            //	END

            //	INSERT INTO [dbo].[Auth] (
            //		[EntityTypeId]
            //		,[EntityId]
            //		,[Order]
            //		,[Action]
            //		,[AllowOrDeny]
            //		,[SpecialRole]
            //		,[Guid]
            //		)
            //	VALUES (
            //		@EntityTypeId
            //		,@PersonEditBlockId
            //		,@Order + 2
            //		,'EditRecordStatus'
            //		,'D'
            //		,1
            //		,NEWID()
            //		)
            //END
            //" );
        }

        /// <summary>
        /// The commands to undo a migration from a specific version
        /// </summary>
        public override void Down()
        {
        }
    }
}
