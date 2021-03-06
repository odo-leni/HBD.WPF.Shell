using System.Windows;
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Suppression;
using Microsoft.Pex.Framework.Validation;
// <copyright file="PexAssemblyInfo.cs">Copyright ©  2016</copyright>

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "MSTestv2")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("HBD.WPF")]
[assembly: PexInstrumentAssembly("System.ComponentModel.Composition")]
[assembly: PexInstrumentAssembly("FontAwesome.WPF")]
[assembly: PexInstrumentAssembly("Prism")]
[assembly: PexInstrumentAssembly("Microsoft.Practices.ServiceLocation")]
[assembly: PexInstrumentAssembly("System.Core")]
[assembly: PexInstrumentAssembly("Microsoft.Expression.Interactions")]
[assembly: PexInstrumentAssembly("System.Xaml")]
[assembly: PexInstrumentAssembly("System.Windows.Forms")]
[assembly: PexInstrumentAssembly("System.ComponentModel.DataAnnotations")]
[assembly: PexInstrumentAssembly("Xcalibur.NativeMethods")]
[assembly: PexInstrumentAssembly("Xcalibur.NativeMethods.Extensions")]
[assembly: PexInstrumentAssembly("PresentationFramework")]
[assembly: PexInstrumentAssembly("WindowsBase")]
[assembly: PexInstrumentAssembly("HBD.Mef")]
[assembly: PexInstrumentAssembly("PresentationCore")]
[assembly: PexInstrumentAssembly("Prism.Wpf")]
[assembly: PexInstrumentAssembly("HBD.Framework")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.ComponentModel.Composition")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "FontAwesome.WPF")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Prism")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.Practices.ServiceLocation")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Core")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.Expression.Interactions")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Xaml")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Windows.Forms")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.ComponentModel.DataAnnotations")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Xcalibur.NativeMethods")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Xcalibur.NativeMethods.Extensions")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "PresentationFramework")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "WindowsBase")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "HBD.Mef")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "PresentationCore")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Prism.Wpf")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "HBD.Framework")]
[assembly: PexSuppressExplorableEvent(typeof(DependencyObject))]

