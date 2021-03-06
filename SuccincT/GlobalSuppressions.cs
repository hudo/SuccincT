using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace",
                           Justification = "Separation of concerns", Target = "SuccincT.Parsers")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace",
                           Justification = "Separation of concerns", Target = "SuccincT.FunctionalComposition")]
[assembly: SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type",
                           Justification = "Special-case exception", Target = "SuccincT.Unions.InvalidCaseException")]
[assembly: SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type",
                           Justification = "Special-case exception",
                           Target = "SuccincT.PatternMatchers.NoMatchException")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Function",
                           Justification = "Extention method", Scope = "type",
                           Target = "SuccincT.FunctionalComposition.Function")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Option",
                           Justification = "No better name (taken from F#)", Scope = "type",
                           Target = "SuccincT.Options.Option`1")]
[assembly: SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes",
                           Justification = "Correct way to construct option", Scope = "member",
                           Target = "SuccincT.Options.Option`1.#None()")]
[assembly: SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes",
                           Justification = "Correct way to construct option", Scope = "member",
                           Target = "SuccincT.Options.Option`1.#Some(!0)")]