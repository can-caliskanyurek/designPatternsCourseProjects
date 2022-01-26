namespace FunctionalBuilder.Classes
{
    public static class PersonBuilderOldExtensions
    {
        public static PersonBuilderOld Called(this PersonBuilderOld builder, string name)
            => builder.Do(person => person.Name = name);

        public static PersonBuilderOld WorksAsA(this PersonBuilderOld builder, string position)
            => builder.Do(person => person.Position = position);
    }
}
