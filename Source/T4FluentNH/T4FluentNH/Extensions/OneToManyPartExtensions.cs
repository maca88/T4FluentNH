using System;
using System.Linq.Expressions;
using FluentNHibernate.Mapping;

namespace T4FluentNH.Extensions
{
    public static class OneToManyPartExtensions
    {
        /// <summary>
        /// Sets KeyColumn by adding "Id" postfix to the Property pointed by columnExp
        /// </summary>
        /// <typeparam name="TChild"></typeparam>
        /// <param name="oneToMany"></param>
        /// <param name="columnExp"></param>
        /// <returns></returns>
        public static OneToManyPart<TChild> KeyColumn<TChild>(this OneToManyPart<TChild> oneToMany, Expression<Func<TChild, object>> columnExp)
        {
            return oneToMany.KeyColumn(columnExp, "", "Id");
        }

        private static OneToManyPart<TChild> KeyColumn<TChild>(this OneToManyPart<TChild> oneToMany, Expression<Func<TChild, object>> columnExp, string prefix, string postfix)
        {
            return oneToMany.KeyColumn(prefix + columnExp.GetFullPropertyName() + postfix);
        }
    }
}
