using System;
using System.Reflection;

namespace Core.Common
{
    public static class ClassFactory
    {
        /// <summary>
        /// Create and return an instance of the specified object type by constructor invocation.
        /// </summary>
        /// <param name="classStrongName">Strong name of the assembly that contains the class to be created and the namespace qualified name of the class.</param>
        /// <param name="paramValues">Set of parameter values to pass into the class constructor.</param>
        /// <returns>The instantiated object.</returns>
        public static object CreateObject(string classStrongName, object[] paramValues = null)
        {
            if (string.IsNullOrWhiteSpace(classStrongName))
            {
                throw new ArgumentException("The class strong name cannot be null, empty, or consist only of whitespace.", "classStrongName");
            }

            var classType = GetClassType(classStrongName);
            return CreateObject(classType, paramValues);
        }

        /// <summary>
        /// Create and return an instance of the specified object type by constructor invocation.
        /// </summary>
        /// <param name="classType">Type of the class to be created.</param>
        /// <param name="paramValues">Set of parameter values to pass into the class constructor.</param>
        /// <returns>The instantiated object.</returns>
        public static object CreateObject(Type classType, object[] paramValues = null)
        {
            Exception exception = null;
            object createdObject = null;

            if (null == classType) throw new ArgumentNullException("classType");
            if (null == paramValues) paramValues = new object[0];

            try
            {
                createdObject = Activator.CreateInstance(classType, paramValues);
            }
            catch (TypeInitializationException ex)
            {
                exception = ex;
            }
            catch (TargetInvocationException ex)
            {
                // Thrown when the invoked method throws an exception
                exception = ex.InnerException ?? ex;
            }
            catch (MethodAccessException ex)
            {
                // Thrown when the caller does not have permission to the constructor
                exception = ex;
            }
            catch (MemberAccessException ex)
            {
                // Thrown if an attempt is made to create an abstract type, or the method invoked is late-bound
                // (This exception also catches MissingMethodException)
                exception = ex;
            }

            if (null != exception)
            {
                throw new ArgumentException("An instance of the type could not be constructed by the constructor");
            }

            return createdObject;
        }

        /// <summary>
        /// Gets the type referenced by the given strong name.
        /// </summary>
        /// <param name="classStrongName">Strong name that defines the type to be returned.</param>
        /// <returns>The type object for the class identified by the given strong name.</returns>
        /// <exception cref="ArgumentException">Thrown if the type cannot be determined or loaded.</exception>
        public static Type GetClassType(string classStrongName)
        {
            if (string.IsNullOrWhiteSpace(classStrongName))
            {
                throw new ArgumentException(@"The class strong name cannot be null, empty, or consist only of whitespace.", "classStrongName");
            }

            Type classType;
            try
            {
                classType = Type.GetType(classStrongName);
            }
            catch (Exception ex)
            {
                // The exception types we expect to perhaps be thrown follow, but we do want to catch/wrap/throw any exception that is thrown:
                //		TypeLoadException			thrown if type name is invalid
                //		FileNotFoundException	thrown if there is an error finding the assembl(y/ies) that contain the type
                //		FileLoadException			thrown if there is an error loading the assembl(y/ies) that contain the type
                //		BadImageFormatException	thrown if the assembl(y/ies) that contain the type are not valid or were compiled with a later version of .NET
                throw new ArgumentException("The type could not be loaded");
            }
            if (null == classType)
            {
                throw new ArgumentException("The type of the class to be created could not be determined");
            }

            return classType;
        }
    }
}