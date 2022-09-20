﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using YumCity_Migrations.HelperClasses;
using YumCity_Migrations.FactoryClasses;
using YumCity_Migrations.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace YumCity_Migrations.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'User'.<br/><br/></summary>
	[Serializable]
	public partial class UserEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		private EntityCollection<RecipeEntity> _recipes;
		private RefreshTokenEntity _refreshToken;
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static UserEntityStaticMetaData _staticMetaData = new UserEntityStaticMetaData();
		private static UserRelations _relationsFactory = new UserRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name RefreshToken</summary>
			public static readonly string RefreshToken = "RefreshToken";
			/// <summary>Member name Recipes</summary>
			public static readonly string Recipes = "Recipes";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class UserEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public UserEntityStaticMetaData()
			{
				SetEntityCoreInfo("UserEntity", InheritanceHierarchyType.None, false, (int)YumCity_Migrations.EntityType.UserEntity, typeof(UserEntity), typeof(UserEntityFactory), false);
				AddNavigatorMetaData<UserEntity, EntityCollection<RecipeEntity>>("Recipes", a => a._recipes, (a, b) => a._recipes = b, a => a.Recipes, () => new UserRelations().RecipeEntityUsingUserId, typeof(RecipeEntity), (int)YumCity_Migrations.EntityType.RecipeEntity);
				AddNavigatorMetaData<UserEntity, RefreshTokenEntity>("RefreshToken", "Users", (a, b) => a._refreshToken = b, a => a._refreshToken, (a, b) => a.RefreshToken = b, YumCity_Migrations.RelationClasses.StaticUserRelations.RefreshTokenEntityUsingRefreshTokenIdStatic, ()=>new UserRelations().RefreshTokenEntityUsingRefreshTokenId, null, new int[] { (int)UserFieldIndex.RefreshTokenId }, null, true, (int)YumCity_Migrations.EntityType.RefreshTokenEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static UserEntity()
		{
		}

		/// <summary> CTor</summary>
		public UserEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public UserEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this UserEntity</param>
		public UserEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for User which data should be fetched into this User object</param>
		public UserEntity(System.Guid id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for User which data should be fetched into this User object</param>
		/// <param name="validator">The custom validator object for this UserEntity</param>
		public UserEntity(System.Guid id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected UserEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Recipe' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecipes() { return CreateRelationInfoForNavigator("Recipes"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'RefreshToken' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRefreshToken() { return CreateRelationInfoForNavigator("RefreshToken"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this UserEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END


			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static UserRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Recipe' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecipes { get { return _staticMetaData.GetPrefetchPathElement("Recipes", CommonEntityBase.CreateEntityCollection<RecipeEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RefreshToken' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRefreshToken { get { return _staticMetaData.GetPrefetchPathElement("RefreshToken", CommonEntityBase.CreateEntityCollection<RefreshTokenEntity>()); } }

		/// <summary>The Id property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "user"."id".<br/>Table field type characteristics (type, precision, scale, length): Uuid, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Guid Id
		{
			get { return (System.Guid)GetValue((int)UserFieldIndex.Id, true); }
			set	{ SetValue((int)UserFieldIndex.Id, value); }
		}

		/// <summary>The IsActive property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "user"."is_active".<br/>Table field type characteristics (type, precision, scale, length): Boolean, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)UserFieldIndex.IsActive, true); }
			set	{ SetValue((int)UserFieldIndex.IsActive, value); }
		}

		/// <summary>The Name property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "user"."name".<br/>Table field type characteristics (type, precision, scale, length): Text, 0, 0, 1073741824.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)UserFieldIndex.Name, true); }
			set	{ SetValue((int)UserFieldIndex.Name, value); }
		}

		/// <summary>The PasswordHash property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "user"."password_hash".<br/>Table field type characteristics (type, precision, scale, length): Text, 0, 0, 1073741824.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String PasswordHash
		{
			get { return (System.String)GetValue((int)UserFieldIndex.PasswordHash, true); }
			set	{ SetValue((int)UserFieldIndex.PasswordHash, value); }
		}

		/// <summary>The RefreshTokenId property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "user"."refresh_token_id".<br/>Table field type characteristics (type, precision, scale, length): Uuid, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Guid> RefreshTokenId
		{
			get { return (Nullable<System.Guid>)GetValue((int)UserFieldIndex.RefreshTokenId, false); }
			set	{ SetValue((int)UserFieldIndex.RefreshTokenId, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'RecipeEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(RecipeEntity))]
		public virtual EntityCollection<RecipeEntity> Recipes { get { return GetOrCreateEntityCollection<RecipeEntity, RecipeEntityFactory>("User", true, false, ref _recipes); } }

		/// <summary>Gets / sets related entity of type 'RefreshTokenEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual RefreshTokenEntity RefreshToken
		{
			get { return _refreshToken; }
			set { SetSingleRelatedEntityNavigator(value, "RefreshToken"); }
		}
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace YumCity_Migrations
{
	public enum UserFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>Name. </summary>
		Name,
		///<summary>PasswordHash. </summary>
		PasswordHash,
		///<summary>RefreshTokenId. </summary>
		RefreshTokenId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace YumCity_Migrations.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: User. </summary>
	public partial class UserRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between UserEntity and RecipeEntity over the 1:n relation they have, using the relation between the fields: User.Id - Recipe.UserId</summary>
		public virtual IEntityRelation RecipeEntityUsingUserId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Recipes", true, new[] { UserFields.Id, RecipeFields.UserId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between UserEntity and RefreshTokenEntity over the m:1 relation they have, using the relation between the fields: User.RefreshTokenId - RefreshToken.Id</summary>
		public virtual IEntityRelation RefreshTokenEntityUsingRefreshTokenId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "RefreshToken", false, new[] { RefreshTokenFields.Id, UserFields.RefreshTokenId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticUserRelations
	{
		internal static readonly IEntityRelation RecipeEntityUsingUserIdStatic = new UserRelations().RecipeEntityUsingUserId;
		internal static readonly IEntityRelation RefreshTokenEntityUsingRefreshTokenIdStatic = new UserRelations().RefreshTokenEntityUsingRefreshTokenId;

		/// <summary>CTor</summary>
		static StaticUserRelations() { }
	}
}
