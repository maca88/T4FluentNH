using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
using T4FluentNH.Metadata;
namespace T4FluentNH.Tests.Naming
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class Case
	{

		#region RelationsMetadata

		public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"Switch", new OneToOneRelationMetadata
                {
					RelatedModelType = typeof(Switch),
					RelatedModelProperty = typeof(Switch).GetProperty("Case"),
					RelatedModelIdProperty = typeof(Switch).GetProperty("Id"),
					AssociationType = AssociationType.Bidirectional,
					Field = typeof(Case).GetField("_switch", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "@switch",
					Property = typeof(Case).GetProperty("Switch"),
					SetMethod = typeof(Case).GetMethods().FirstOrDefault(o => o.Name == "SetSwitch" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(Switch)),
					UnsetMethod = typeof(Case).GetMethods().FirstOrDefault(o => o.Name == "UnsetSwitch" && o.GetParameters().Length == 0),
					SyntheticProperty = typeof(Case).GetProperty("SwitchId"),
					SyntheticField = typeof(Case).GetField("_switchId", BindingFlags.Instance | BindingFlags.NonPublic),
					SyntheticPropertyMaxLength = null,
					IsSyntheticPropertyTypeRequired = false,
					
                }},
		
                {"Uses", new OneToManyRelationMetadata
                {
					RelatedModelType = typeof(Use),
					RelatedModelProperty = typeof(Use).GetProperty("Case"),
					RelatedModelIdProperty = typeof(Use).GetProperty("Id"),
					AssociationType = AssociationType.Bidirectional,
					Field = typeof(Case).GetField("_uses", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "us",
					Property = typeof(Case).GetProperty("Uses"),
                    AddMethod = typeof(Case).GetMethods().FirstOrDefault(o => o.Name == "AddUse" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(Use)),
					RemoveMethod = typeof(Case).GetMethods().FirstOrDefault(o => o.Name == "RemoveUse" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(Use)),
					CollectionMapType = CollectionMapType.Unknown,
					
                }},
		
            };

		#endregion

		#region Switch

        private Switch _switch;

        [ReadOnly(true)]
		public virtual int? SwitchId 
		{ 
			get { return _switchId != default(int?) || Switch == null ? _switchId : Switch.Id; } 
			set { _switchId = value; }
		}

		private int? _switchId;

		public virtual void SetSwitch(Switch @switch)
        {
			this.SetOneToOne(o => o.Switch, @switch, o => o.Case);
        }

        public virtual void UnsetSwitch()
        {
			this.UnsetOneToOne(o => o.Switch, o => o.Case);
        }	

		#endregion

		#region Uses

		private ISet<Use> _uses;

        public virtual void AddUse(Use us)
        {
            this.AddOneToMany(o => o.Uses, us, o => o.Case, o=> o.RemoveUse);
        }

        public virtual void RemoveUse(Use us)
        {
			this.RemoveOneToMany(o => o.Uses, us, o => o.Case);
        }

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
