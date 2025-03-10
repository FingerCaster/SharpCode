using System;
using Optional;

namespace SharpCode
{
    /// <summary>
    /// Provides functionality for creating various source code builders.
    /// </summary>
    public static class Code
    {
        /// <summary>
        /// Creates a new <see cref="NamespaceBuilder"/> instance for building namespaces.
        /// </summary>
        public static NamespaceBuilder CreateNamespace() =>
            new NamespaceBuilder();

        /// <summary>
        /// Creates a new pre-configured <see cref="NamespaceBuilder"/> instance for building namespaces. Configures
        /// the <see cref="NamespaceBuilder"/> instance with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">
        /// The name of the namespace. Used as-is.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// The specified <paramref name="name"/> is <c>null</c>.
        /// </exception>
        public static NamespaceBuilder CreateNamespace(string name) =>
            name is null
            ? throw new ArgumentNullException(nameof(name))
            : new NamespaceBuilder(name);

        /// <summary>
        /// Creates a new <see cref="EnumBuilder"/> instance for building enums.
        /// </summary>
        public static EnumBuilder CreateEnum() =>
            new EnumBuilder();

        /// <summary>
        /// Creates a new pre-configured <see cref="EnumBuilder"/> instance for building enums. Configures the
        /// <see cref="EnumBuilder"/> instance with the specified <paramref name="name"/> and
        /// <paramref name="accessModifier"/>.
        /// </summary>
        /// <param name="name">
        /// The name of the enum.
        /// </param>
        /// <param name="accessModifier">
        /// The access modifier of the enum.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// The specified <paramref name="name"/> is <c>null</c>.
        /// </exception>
        public static EnumBuilder CreateEnum(string name, AccessModifier accessModifier = AccessModifier.Public) =>
            name is null
            ? throw new ArgumentNullException(nameof(name))
            : new EnumBuilder(name, accessModifier);

        /// <summary>
        /// Creates a new <see cref="EnumMemberBuilder"/> instance for building enum members.
        /// </summary>
        public static EnumMemberBuilder CreateEnumMember() =>
            new EnumMemberBuilder();

        /// <summary>
        /// Creates a new pre-configured <see cref="EnumMemberBuilder"/> instance for building enum members. Configures
        /// the <see cref="EnumMemberBuilder"/> instance with the specified <paramref name="name"/> and
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="name">
        /// The name of the enum member.
        /// </param>
        /// <param name="value">
        /// Optional. Explicitly specifies the value of the enum member. <b>Note</b> that if the enum is marked as
        /// flags, via <see cref="EnumBuilder.MakeFlagsEnum(bool)"/>, you need to explicitly provide the values of all
        /// members to ensure correct functionality. Flags enums for which no member has an explicit value will
        /// auto-generate appropriate values for each member.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// The specified <paramref name="name"/> is <c>null</c>.
        /// </exception>
        public static EnumMemberBuilder CreateEnumMember(string name, int? value = null) =>
            name is null
            ? throw new ArgumentNullException(nameof(name))
            : new EnumMemberBuilder(name, value.ToOption());

        /// <summary>
        /// Creates a new <see cref="InterfaceBuilder"/> instance for building interface structures.
        /// </summary>
        public static InterfaceBuilder CreateInterface() =>
            new InterfaceBuilder();

        /// <summary>
        /// Creates a new pre-configured <see cref="InterfaceBuilder"/> instance for building interface structures.
        /// Configures the <see cref="InterfaceBuilder"/> with the specified <paramref name="name"/> and
        /// <paramref name="accessModifier"/>.
        /// </summary>
        /// <param name="name">
        /// The name of the interface. Used as-is.
        /// </param>
        /// <param name="accessModifier">
        /// The access modifier of the interface.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// The specified <paramref name="name"/> is <c>null</c>.
        /// </exception>
        public static InterfaceBuilder CreateInterface(
            string name,
            AccessModifier accessModifier = AccessModifier.Public) =>
            name is null
            ? throw new ArgumentNullException(nameof(name))
            : new InterfaceBuilder(name, accessModifier);

        /// <summary>
        /// Creates a new <see cref="ClassBuilder"/> instance for building class structures.
        /// </summary>
        public static ClassBuilder CreateClass() =>
            new ClassBuilder();

        /// <summary>
        /// Creates a new pre-configured <see cref="ClassBuilder"/> instance for building class structures. Configures
        /// the <see cref="ClassBuilder"/> with the specified <paramref name="name"/> and
        /// <paramref name="accessModifier"/>.
        /// </summary>
        /// <param name="name">
        /// The name of the class. Used as-is.
        /// </param>
        /// <param name="accessModifier">
        /// The access modifier of the class.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// The specified <paramref name="name"/> is <c>null</c>.
        /// </exception>
        public static ClassBuilder CreateClass(string name, AccessModifier accessModifier = AccessModifier.Public) =>
            name is null
            ? throw new ArgumentNullException(nameof(name))
            : new ClassBuilder(accessModifier, name);

        /// <summary>
        /// Creates a new <see cref="StructBuilder"/> instance for building structs.
        /// </summary>
        public static StructBuilder CreateStruct() =>
            new StructBuilder();

        /// <summary>
        /// Creates a new pre-configured <see cref="StructBuilder"/> instance for building structs. Configures the
        /// <see cref="StructBuilder"/> instance with the specified <paramref name="name"/> and
        /// <paramref name="accessModifier"/>.
        /// </summary>
        /// <param name="name">
        /// The name of the struct.
        /// </param>
        /// <param name="accessModifier">
        /// The access modifier of the struct.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// The specified <paramref name="name"/> is <c>null</c>.
        /// </exception>
        public static StructBuilder CreateStruct(string name, AccessModifier accessModifier = AccessModifier.Public) =>
            name is null
            ? throw new ArgumentNullException(nameof(name))
            : new StructBuilder(name, accessModifier);

        /// <summary>
        /// Creates a new <see cref="FieldBuilder"/> instance for building fields.
        /// </summary>
        public static FieldBuilder CreateField() =>
            new FieldBuilder();

        /// <summary>
        /// Creates a new pre-configured <see cref="FieldBuilder"/> instance for building fields. Configures the
        /// <see cref="FieldBuilder"/> with the specified <paramref name="type"/>, <paramref name="name"/> and
        /// <paramref name="accessModifier"/>.
        /// </summary>
        /// <param name="type">
        /// The type of the field, eg. <c>int</c>, <c>string</c>, <c>User</c>. Used as-is.
        /// </param>
        /// <param name="name">
        /// The name of the field. Used as-is.
        /// </param>
        /// <param name="accessModifier">
        /// The access of modifier of the field.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// If the specified <paramref name="type"/> and/or <paramref name="name"/> are <c>null</c>.
        /// </exception>
        public static FieldBuilder CreateField(
            string type,
            string name,
            AccessModifier accessModifier = AccessModifier.Private)
        {
            if (type is null)
            {
                throw new ArgumentNullException(nameof(type));
            }
            else if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return new FieldBuilder(accessModifier, type, name);
        }

        /// <summary>
        /// Creates a new pre-configured <see cref="FieldBuilder"/> instance for building fields. Configures the
        /// <see cref="FieldBuilder"/> with the specified <paramref name="type"/>, <paramref name="name"/> and
        /// <paramref name="accessModifier"/>.
        /// </summary>
        /// <param name="type">
        /// Used to derive the type of the field. The derived type of the field will use the framework keyword instead
        /// of the language keyword, eg. <c>Int32</c> instead of <c>int</c> and <c>String</c> instead of <c>string</c>.
        /// </param>
        /// <param name="name">
        /// The name of the field. Used as-is.
        /// </param>
        /// <param name="accessModifier">
        /// The access of modifier of the field.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// If the specified <paramref name="type"/> and/or <paramref name="name"/> are <c>null</c>.
        /// </exception>
        public static FieldBuilder CreateField(
            Type type,
            string name,
            AccessModifier accessModifier = AccessModifier.Private)
        {
            if (type is null)
            {
                throw new ArgumentNullException(nameof(type));
            }
            else if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return new FieldBuilder(accessModifier, type, name);
        }

        /// <summary>
        /// Creates a new <see cref="ConstructorBuilder"/> instance for building constructors.
        /// </summary>
        public static ConstructorBuilder CreateConstructor(AccessModifier accessModifier = AccessModifier.Public) =>
            new ConstructorBuilder(accessModifier);

        /// <summary>
        /// Creates a new <see cref="PropertyBuilder"/> instance for building properties.
        /// </summary>
        public static PropertyBuilder CreateProperty() =>
            new PropertyBuilder();

        /// <summary>
        /// Creates a new pre-configured <see cref="PropertyBuilder"/> instance for building properties. Configures the
        /// <see cref="PropertyBuilder"/> with the specified <paramref name="type"/>, <paramref name="name"/> and
        /// <paramref name="accessModifier"/>.
        /// </summary>
        /// <param name="type">
        /// The type of the property, eg. <c>int</c>, <c>string</c>, <c>User</c>. Used as-is.
        /// </param>
        /// <param name="name">
        /// The name of the property. Used as-is.
        /// </param>
        /// <param name="accessModifier">
        /// The access of modifier of the property.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// If the specified <paramref name="type"/> and/or <paramref name="name"/> are <c>null</c>.
        /// </exception>
        public static PropertyBuilder CreateProperty(
            string type,
            string name,
            AccessModifier accessModifier = AccessModifier.Public)
        {
            if (type is null)
            {
                throw new ArgumentNullException(nameof(type));
            }
            else if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return new PropertyBuilder(accessModifier, type, name);
        }

        /// <summary>
        /// Creates a new pre-configured <see cref="PropertyBuilder"/> instance for building properties. Configures the
        /// <see cref="PropertyBuilder"/> with the specified <paramref name="type"/>, <paramref name="name"/> and
        /// <paramref name="accessModifier"/>.
        /// </summary>
        /// <param name="type">
        /// Used to derive the type of the property. The derived type of the field will use the framework keyword
        /// instead of the language keyword, eg. <c>Int32</c> instead of <c>int</c> and <c>String</c> instead of
        /// <c>string</c>.
        /// </param>
        /// <param name="name">
        /// The name of the property. Used as-is.
        /// </param>
        /// <param name="accessModifier">
        /// The access of modifier of the property.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// If the specified <paramref name="type"/> and/or <paramref name="name"/> are <c>null</c>.
        /// </exception>
        public static PropertyBuilder CreateProperty(
            Type type,
            string name,
            AccessModifier accessModifier = AccessModifier.Public)
        {
            if (type is null)
            {
                throw new ArgumentNullException(nameof(type));
            }
            else if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return new PropertyBuilder(accessModifier, type, name);
        }
    }
}
