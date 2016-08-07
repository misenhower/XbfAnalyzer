using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XbfAnalyzer.Xbf
{
    public static class XbfFrameworkTypes
    {
        public static string GetNameForTypeID(int id)
        {
            if (id - 0x8001 >= 0 && id - 0x8001 < typeNames.Length)
                return typeNames[id - 0x8001];
            else
                return null;
        }

        public static string GetNameForPropertyID(int id)
        {
            if (id - 0x8001 >= 0 && id - 0x8001 < propertyNames.Length)
                return propertyNames[id - 0x8001];
            else
                return null;
        }

        // mappings are hard-coded in GenXbf.dll from Windows SDK
        // up-to-date as of Anniversary Update (build 14393)

        private static readonly string[] typeNames = {
            /* 0x8001 */ "Byte", // Windows.Foundation.Byte
            /* 0x8002 */ "Char16", // Windows.Foundation.Char16
            /* 0x8003 */ "DateTime", // Windows.Foundation.DateTime
            /* 0x8004 */ "GeneratorPosition", // Windows.UI.Xaml.Controls.Primitives.GeneratorPosition
            /* 0x8005 */ "Guid", // Windows.Foundation.Guid
            /* 0x8006 */ "Int16", // Windows.Foundation.Int16
            /* 0x8007 */ "Int64", // Windows.Foundation.Int64
            /* 0x8008 */ "Object", // Windows.Foundation.Object
            /* 0x8009 */ "Single", // Windows.Foundation.Single
            /* 0x800A */ "TypeName", // Windows.UI.Xaml.Interop.TypeName
            /* 0x800B */ "UInt16", // Windows.Foundation.UInt16
            /* 0x800C */ "UInt32", // Windows.Foundation.UInt32
            /* 0x800D */ "UInt64", // Windows.Foundation.UInt64
            /* 0x800E */ "AutomationProperties", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x800F */ "DataPackage", // Windows.ApplicationModel.DataTransfer.DataPackage
            /* 0x8010 */ "DataTemplateSelector", // Windows.UI.Xaml.Controls.DataTemplateSelector
            /* 0x8011 */ "DependencyObject", // Windows.UI.Xaml.DependencyObject
            /* 0x8012 */ "EventHandler", // Windows.Foundation.EventHandler
            /* 0x8013 */ "GroupStyleCollection", // Windows.UI.Xaml.Controls.GroupStyleCollection
            /* 0x8014 */ "GroupStyleSelector", // Windows.UI.Xaml.Controls.GroupStyleSelector
            /* 0x8015 */ "ItemContainerGenerator", // Windows.UI.Xaml.Controls.ItemContainerGenerator
            /* 0x8016 */ "ListViewPersistenceHelper", // Windows.UI.Xaml.Controls.ListViewPersistenceHelper
            /* 0x8017 */ "StyleSelector", // Windows.UI.Xaml.Controls.StyleSelector
            /* 0x8018 */ "TextOptions", // Windows.UI.Xaml.TextOptions
            /* 0x8019 */ "ToolTipService", // Windows.UI.Xaml.Controls.ToolTipService
            /* 0x801A */ "Typography", // Windows.UI.Xaml.Documents.Typography
            /* 0x801B */ "Uri", // Windows.Foundation.Uri
            /* 0x801C */ "MediaCapture", // Windows.Media.Capture.MediaCapture
            /* 0x801D */ "PlayToSource", // Windows.Media.PlayTo.PlayToSource
            /* 0x801E */ "MediaProtectionManager", // Windows.Media.Protection.MediaProtectionManager
            /* 0x801F */ "Application", // Windows.UI.Xaml.Application
            /* 0x8020 */ "ApplicationBarService", // Windows.UI.Xaml.Controls.ApplicationBarService
            /* 0x8021 */ "AutomationPeer", // Windows.UI.Xaml.Automation.Peers.AutomationPeer
            /* 0x8022 */ "AutoSuggestBoxSuggestionChosenEventArgs", // Windows.UI.Xaml.Controls.AutoSuggestBoxSuggestionChosenEventArgs
            /* 0x8023 */ "AutoSuggestBoxTextChangedEventArgs", // Windows.UI.Xaml.Controls.AutoSuggestBoxTextChangedEventArgs
            /* 0x8024 */ "Boolean", // Windows.Foundation.Boolean
            /* 0x8025 */ "Brush", // Windows.UI.Xaml.Media.Brush
            /* 0x8026 */ "CacheMode", // Windows.UI.Xaml.Media.CacheMode
            /* 0x8027 */ "CollectionView", // Windows.UI.Xaml.Data.CollectionView
            /* 0x8028 */ "CollectionViewGroup", // Windows.UI.Xaml.Data.CollectionViewGroup
            /* 0x8029 */ "CollectionViewSource", // Windows.UI.Xaml.Data.CollectionViewSource
            /* 0x802A */ "Color", // Windows.UI.Color
            /* 0x802B */ "ColorKeyFrame", // Windows.UI.Xaml.Media.Animation.ColorKeyFrame
            /* 0x802C */ "ColumnDefinition", // Windows.UI.Xaml.Controls.ColumnDefinition
            /* 0x802D */ "ComboBoxTemplateSettings", // Windows.UI.Xaml.Controls.Primitives.ComboBoxTemplateSettings
            /* 0x802E */ "CornerRadius", // Windows.UI.Xaml.CornerRadius
            /* 0x802F */ null,
            /* 0x8030 */ "DebugSettings", // Windows.UI.Xaml.DebugSettings
            /* 0x8031 */ "DependencyObjectWrapper", // Windows.UI.Xaml.Internal.DependencyObjectWrapper
            /* 0x8032 */ "DependencyProperty", // Windows.UI.Xaml.DependencyProperty
            /* 0x8033 */ "Deployment", // Windows.UI.Xaml.Deployment
            /* 0x8034 */ "Double", // Windows.Foundation.Double
            /* 0x8035 */ "DoubleKeyFrame", // Windows.UI.Xaml.Media.Animation.DoubleKeyFrame
            /* 0x8036 */ null,
            /* 0x8037 */ "EasingFunctionBase", // Windows.UI.Xaml.Media.Animation.EasingFunctionBase
            /* 0x8038 */ "Enumerated", // Windows.Foundation.Enumerated
            /* 0x8039 */ "ExternalObjectReference", // Windows.UI.Xaml.Internal.ExternalObjectReference
            /* 0x803A */ "FlyoutBase", // Windows.UI.Xaml.Controls.Primitives.FlyoutBase
            /* 0x803B */ "FontFamily", // Windows.UI.Xaml.Media.FontFamily
            /* 0x803C */ "FontWeight", // Windows.UI.Text.FontWeight
            /* 0x803D */ "FrameworkTemplate", // Windows.UI.Xaml.FrameworkTemplate
            /* 0x803E */ "GeneralTransform", // Windows.UI.Xaml.Media.GeneralTransform
            /* 0x803F */ "Geometry", // Windows.UI.Xaml.Media.Geometry
            /* 0x8040 */ "GradientStop", // Windows.UI.Xaml.Media.GradientStop
            /* 0x8041 */ "GridLength", // Windows.UI.Xaml.GridLength
            /* 0x8042 */ "GroupStyle", // Windows.UI.Xaml.Controls.GroupStyle
            /* 0x8043 */ "HWCompNode", // Windows.UI.Xaml.Internal.HWCompNode
            /* 0x8044 */ "ImageSource", // Windows.UI.Xaml.Media.ImageSource
            /* 0x8045 */ "IMECandidateItem", // Windows.UI.Xaml.Controls.IMECandidateItem
            /* 0x8046 */ "IMECandidatePage", // Windows.UI.Xaml.Controls.IMECandidatePage
            /* 0x8047 */ "InertiaExpansionBehavior", // Windows.UI.Xaml.Input.InertiaExpansionBehavior
            /* 0x8048 */ "InertiaRotationBehavior", // Windows.UI.Xaml.Input.InertiaRotationBehavior
            /* 0x8049 */ "InertiaTranslationBehavior", // Windows.UI.Xaml.Input.InertiaTranslationBehavior
            /* 0x804A */ "InputScope", // Windows.UI.Xaml.Input.InputScope
            /* 0x804B */ "InputScopeName", // Windows.UI.Xaml.Input.InputScopeName
            /* 0x804C */ "Int32", // Windows.Foundation.Int32
            /* 0x804D */ "IRawElementProviderSimple", // Windows.UI.Xaml.Automation.Provider.IRawElementProviderSimple
            /* 0x804E */ "KeySpline", // Windows.UI.Xaml.Media.Animation.KeySpline
            /* 0x804F */ "LayoutTransitionStaggerItem", // Windows.UI.Xaml.LayoutTransitionStaggerItem
            /* 0x8050 */ "LengthConverter", // Windows.UI.Xaml.LengthConverter
            /* 0x8051 */ "ListViewBaseItemTemplateSettings", // Windows.UI.Xaml.Controls.Primitives.ListViewBaseItemTemplateSettings
            /* 0x8052 */ "ManipulationDelta", // Windows.UI.Xaml.Input.ManipulationDelta
            /* 0x8053 */ "ManipulationPivot", // Windows.UI.Xaml.Input.ManipulationPivot
            /* 0x8054 */ "ManipulationVelocities", // Windows.UI.Xaml.Input.ManipulationVelocities
            /* 0x8055 */ "MarkupExtensionBase", // Windows.UI.Xaml.MarkupExtensionBase
            /* 0x8056 */ "Matrix", // Windows.UI.Xaml.Media.Matrix
            /* 0x8057 */ "Matrix3D", // Windows.UI.Xaml.Media.Media3D.Matrix3D
            /* 0x8058 */ "NavigationTransitionInfo", // Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo
            /* 0x8059 */ "ObjectKeyFrame", // Windows.UI.Xaml.Media.Animation.ObjectKeyFrame
            /* 0x805A */ "PageStackEntry", // Windows.UI.Xaml.Navigation.PageStackEntry
            /* 0x805B */ "ParametricCurve", // Windows.UI.Xaml.Internal.ParametricCurve
            /* 0x805C */ "ParametricCurveSegment", // Windows.UI.Xaml.Internal.ParametricCurveSegment
            /* 0x805D */ "PathFigure", // Windows.UI.Xaml.Media.PathFigure
            /* 0x805E */ "PathSegment", // Windows.UI.Xaml.Media.PathSegment
            /* 0x805F */ "Point", // Windows.Foundation.Point
            /* 0x8060 */ "Pointer", // Windows.UI.Xaml.Input.Pointer
            /* 0x8061 */ "PointerKeyFrame", // Windows.UI.Xaml.Internal.PointerKeyFrame
            /* 0x8062 */ "PointKeyFrame", // Windows.UI.Xaml.Media.Animation.PointKeyFrame
            /* 0x8063 */ "PresentationFrameworkCollection", // Windows.UI.Xaml.Collections.PresentationFrameworkCollection
            /* 0x8064 */ "PrintDocument", // Windows.UI.Xaml.Printing.PrintDocument
            /* 0x8065 */ "ProgressBarTemplateSettings", // Windows.UI.Xaml.Controls.Primitives.ProgressBarTemplateSettings
            /* 0x8066 */ "ProgressRingTemplateSettings", // Windows.UI.Xaml.Controls.Primitives.ProgressRingTemplateSettings
            /* 0x8067 */ "Projection", // Windows.UI.Xaml.Media.Projection
            /* 0x8068 */ "PropertyPath", // Windows.UI.Xaml.PropertyPath
            /* 0x8069 */ "Rect", // Windows.Foundation.Rect
            /* 0x806A */ "RowDefinition", // Windows.UI.Xaml.Controls.RowDefinition
            /* 0x806B */ "SecondaryContentRelationship", // Windows.UI.Xaml.Internal.SecondaryContentRelationship
            /* 0x806C */ "SetterBase", // Windows.UI.Xaml.SetterBase
            /* 0x806D */ "SettingsFlyoutTemplateSettings", // Windows.UI.Xaml.Controls.Primitives.SettingsFlyoutTemplateSettings
            /* 0x806E */ "Size", // Windows.Foundation.Size
            /* 0x806F */ "SolidColorBrushClone", // Windows.UI.Xaml.Internal.SolidColorBrushClone
            /* 0x8070 */ "StaggerFunctionBase", // Windows.UI.Xaml.StaggerFunctionBase
            /* 0x8071 */ "String", // Windows.Foundation.String
            /* 0x8072 */ "Style", // Windows.UI.Xaml.Style
            /* 0x8073 */ "TemplateContent", // Windows.UI.Xaml.Internal.TemplateContent
            /* 0x8074 */ "TextAdapter", // Windows.UI.Xaml.Automation.Peers.TextAdapter
            /* 0x8075 */ null,
            /* 0x8076 */ "TextDecorationCollection", // Windows.UI.Xaml.TextDecorationCollection
            /* 0x8077 */ "TextElement", // Windows.UI.Xaml.Documents.TextElement
            /* 0x8078 */ "TextPointerWrapper", // Windows.UI.Xaml.Internal.TextPointerWrapper
            /* 0x8079 */ "TextProvider", // MS.Internal.Automation.TextProvider
            /* 0x807A */ "TextRangeAdapter", // Windows.UI.Xaml.Automation.Peers.TextRangeAdapter
            /* 0x807B */ "TextRangeProvider", // MS.Internal.Automation.TextRangeProvider
            /* 0x807C */ "Thickness", // Windows.UI.Xaml.Thickness
            /* 0x807D */ "Timeline", // Windows.UI.Xaml.Media.Animation.Timeline
            /* 0x807E */ "TimelineMarker", // Windows.UI.Xaml.Media.TimelineMarker
            /* 0x807F */ "TimeSpan", // Windows.Foundation.TimeSpan
            /* 0x8080 */ "ToggleSwitchTemplateSettings", // Windows.UI.Xaml.Controls.Primitives.ToggleSwitchTemplateSettings
            /* 0x8081 */ "ToolTipTemplateSettings", // Windows.UI.Xaml.Controls.Primitives.ToolTipTemplateSettings
            /* 0x8082 */ "Transition", // Windows.UI.Xaml.Media.Animation.Transition
            /* 0x8083 */ "TransitionTarget", // Windows.UI.Xaml.Media.Animation.TransitionTarget
            /* 0x8084 */ "TriggerAction", // Windows.UI.Xaml.TriggerAction
            /* 0x8085 */ "TriggerBase", // Windows.UI.Xaml.TriggerBase
            /* 0x8086 */ null,
            /* 0x8087 */ "UIElement", // Windows.UI.Xaml.UIElement
            /* 0x8088 */ "UIElementClone", // Windows.UI.Xaml.Internal.UIElementClone
            /* 0x8089 */ "VisualState", // Windows.UI.Xaml.VisualState
            /* 0x808A */ "VisualStateGroup", // Windows.UI.Xaml.VisualStateGroup
            /* 0x808B */ "VisualStateManager", // Windows.UI.Xaml.VisualStateManager
            /* 0x808C */ "VisualTransition", // Windows.UI.Xaml.VisualTransition
            /* 0x808D */ "Window", // Windows.UI.Xaml.Window
            /* 0x808E */ null,
            /* 0x808F */ null,
            /* 0x8090 */ null,
            /* 0x8091 */ null,
            /* 0x8092 */ null,
            /* 0x8093 */ null,
            /* 0x8094 */ null,
            /* 0x8095 */ null,
            /* 0x8096 */ null,
            /* 0x8097 */ null,
            /* 0x8098 */ null,
            /* 0x8099 */ null,
            /* 0x809A */ null,
            /* 0x809B */ null,
            /* 0x809C */ null,
            /* 0x809D */ null,
            /* 0x809E */ null,
            /* 0x809F */ null,
            /* 0x80A0 */ null,
            /* 0x80A1 */ null,
            /* 0x80A2 */ null,
            /* 0x80A3 */ null,
            /* 0x80A4 */ null,
            /* 0x80A5 */ null,
            /* 0x80A6 */ null,
            /* 0x80A7 */ null,
            /* 0x80A8 */ null,
            /* 0x80A9 */ null,
            /* 0x80AA */ null,
            /* 0x80AB */ null,
            /* 0x80AC */ null,
            /* 0x80AD */ null,
            /* 0x80AE */ null,
            /* 0x80AF */ null,
            /* 0x80B0 */ null,
            /* 0x80B1 */ "AddDeleteThemeTransition", // Windows.UI.Xaml.Media.Animation.AddDeleteThemeTransition
            /* 0x80B2 */ "ArcSegment", // Windows.UI.Xaml.Media.ArcSegment
            /* 0x80B3 */ "BackEase", // Windows.UI.Xaml.Media.Animation.BackEase
            /* 0x80B4 */ "BeginStoryboard", // Windows.UI.Xaml.Media.Animation.BeginStoryboard
            /* 0x80B5 */ "BezierSegment", // Windows.UI.Xaml.Media.BezierSegment
            /* 0x80B6 */ "BindingBase", // Windows.UI.Xaml.Data.BindingBase
            /* 0x80B7 */ "BitmapCache", // Windows.UI.Xaml.Media.BitmapCache
            /* 0x80B8 */ "BitmapSource", // Windows.UI.Xaml.Media.Imaging.BitmapSource
            /* 0x80B9 */ "Block", // Windows.UI.Xaml.Documents.Block
            /* 0x80BA */ "BounceEase", // Windows.UI.Xaml.Media.Animation.BounceEase
            /* 0x80BB */ "CircleEase", // Windows.UI.Xaml.Media.Animation.CircleEase
            /* 0x80BC */ "ColorAnimation", // Windows.UI.Xaml.Media.Animation.ColorAnimation
            /* 0x80BD */ "ColorAnimationUsingKeyFrames", // Windows.UI.Xaml.Media.Animation.ColorAnimationUsingKeyFrames
            /* 0x80BE */ "ContentThemeTransition", // Windows.UI.Xaml.Media.Animation.ContentThemeTransition
            /* 0x80BF */ "ControlTemplate", // Windows.UI.Xaml.Controls.ControlTemplate
            /* 0x80C0 */ "CubicEase", // Windows.UI.Xaml.Media.Animation.CubicEase
            /* 0x80C1 */ "CustomResource", // Windows.UI.Xaml.CustomResource
            /* 0x80C2 */ "DataTemplate", // Windows.UI.Xaml.DataTemplate
            /* 0x80C3 */ "DiscreteColorKeyFrame", // Windows.UI.Xaml.Media.Animation.DiscreteColorKeyFrame
            /* 0x80C4 */ "DiscreteDoubleKeyFrame", // Windows.UI.Xaml.Media.Animation.DiscreteDoubleKeyFrame
            /* 0x80C5 */ "DiscreteObjectKeyFrame", // Windows.UI.Xaml.Media.Animation.DiscreteObjectKeyFrame
            /* 0x80C6 */ "DiscretePointKeyFrame", // Windows.UI.Xaml.Media.Animation.DiscretePointKeyFrame
            /* 0x80C7 */ "DispatcherTimer", // Windows.UI.Xaml.DispatcherTimer
            /* 0x80C8 */ "DoubleAnimation", // Windows.UI.Xaml.Media.Animation.DoubleAnimation
            /* 0x80C9 */ "DoubleAnimationUsingKeyFrames", // Windows.UI.Xaml.Media.Animation.DoubleAnimationUsingKeyFrames
            /* 0x80CA */ "Duration", // Windows.UI.Xaml.Duration
            /* 0x80CB */ "DynamicTimeline", // Windows.UI.Xaml.Media.Animation.DynamicTimeline
            /* 0x80CC */ "EasingColorKeyFrame", // Windows.UI.Xaml.Media.Animation.EasingColorKeyFrame
            /* 0x80CD */ "EasingDoubleKeyFrame", // Windows.UI.Xaml.Media.Animation.EasingDoubleKeyFrame
            /* 0x80CE */ "EasingPointKeyFrame", // Windows.UI.Xaml.Media.Animation.EasingPointKeyFrame
            /* 0x80CF */ "EdgeUIThemeTransition", // Windows.UI.Xaml.Media.Animation.EdgeUIThemeTransition
            /* 0x80D0 */ "ElasticEase", // Windows.UI.Xaml.Media.Animation.ElasticEase
            /* 0x80D1 */ "EllipseGeometry", // Windows.UI.Xaml.Media.EllipseGeometry
            /* 0x80D2 */ "EntranceThemeTransition", // Windows.UI.Xaml.Media.Animation.EntranceThemeTransition
            /* 0x80D3 */ "EventTrigger", // Windows.UI.Xaml.EventTrigger
            /* 0x80D4 */ "ExponentialEase", // Windows.UI.Xaml.Media.Animation.ExponentialEase
            /* 0x80D5 */ "Flyout", // Windows.UI.Xaml.Controls.Flyout
            /* 0x80D6 */ "FrameworkElement", // Windows.UI.Xaml.FrameworkElement
            /* 0x80D7 */ "FrameworkElementAutomationPeer", // Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer
            /* 0x80D8 */ "GeometryGroup", // Windows.UI.Xaml.Media.GeometryGroup
            /* 0x80D9 */ "GradientBrush", // Windows.UI.Xaml.Media.GradientBrush
            /* 0x80DA */ "GridViewItemTemplateSettings", // Windows.UI.Xaml.Controls.Primitives.GridViewItemTemplateSettings
            /* 0x80DB */ "GroupedDataCollectionView", // Windows.UI.Xaml.Data.GroupedDataCollectionView
            /* 0x80DC */ "HWCompLeafNode", // Windows.UI.Xaml.Internal.HWCompLeafNode
            /* 0x80DD */ "HWCompTreeNode", // Windows.UI.Xaml.Internal.HWCompTreeNode
            /* 0x80DE */ "HyperlinkAutomationPeer", // Windows.UI.Xaml.Automation.Peers.HyperlinkAutomationPeer
            /* 0x80DF */ "Inline", // Windows.UI.Xaml.Documents.Inline
            /* 0x80E0 */ "InputPaneThemeTransition", // Windows.UI.Xaml.Media.Animation.InputPaneThemeTransition
            /* 0x80E1 */ "InternalTransform", // Windows.UI.Xaml.Internal.InternalTransform
            /* 0x80E2 */ "ItemAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ItemAutomationPeer
            /* 0x80E3 */ "ItemsPanelTemplate", // Windows.UI.Xaml.Controls.ItemsPanelTemplate
            /* 0x80E4 */ "KeyTime", // Windows.UI.Xaml.Media.Animation.KeyTime
            /* 0x80E5 */ "LayoutTransitionElement", // Windows.UI.Xaml.Internal.LayoutTransitionElement
            /* 0x80E6 */ "LinearColorKeyFrame", // Windows.UI.Xaml.Media.Animation.LinearColorKeyFrame
            /* 0x80E7 */ "LinearDoubleKeyFrame", // Windows.UI.Xaml.Media.Animation.LinearDoubleKeyFrame
            /* 0x80E8 */ "LinearPointKeyFrame", // Windows.UI.Xaml.Media.Animation.LinearPointKeyFrame
            /* 0x80E9 */ "LineGeometry", // Windows.UI.Xaml.Media.LineGeometry
            /* 0x80EA */ "LineSegment", // Windows.UI.Xaml.Media.LineSegment
            /* 0x80EB */ "ListViewItemTemplateSettings", // Windows.UI.Xaml.Controls.Primitives.ListViewItemTemplateSettings
            /* 0x80EC */ "Matrix3DProjection", // Windows.UI.Xaml.Media.Matrix3DProjection
            /* 0x80ED */ "MediaSwapChainElement", // Windows.UI.Xaml.Internal.MediaSwapChainElement
            /* 0x80EE */ "MenuFlyout", // Windows.UI.Xaml.Controls.MenuFlyout
            /* 0x80EF */ "NullExtension", // Windows.UI.Xaml.NullExtension
            /* 0x80F0 */ "ObjectAnimationUsingKeyFrames", // Windows.UI.Xaml.Media.Animation.ObjectAnimationUsingKeyFrames
            /* 0x80F1 */ "PaneThemeTransition", // Windows.UI.Xaml.Media.Animation.PaneThemeTransition
            /* 0x80F2 */ "ParallelTimeline", // Windows.UI.Xaml.Media.Animation.ParallelTimeline
            /* 0x80F3 */ "PathGeometry", // Windows.UI.Xaml.Media.PathGeometry
            /* 0x80F4 */ "PlaneProjection", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x80F5 */ "PointAnimation", // Windows.UI.Xaml.Media.Animation.PointAnimation
            /* 0x80F6 */ "PointAnimationUsingKeyFrames", // Windows.UI.Xaml.Media.Animation.PointAnimationUsingKeyFrames
            /* 0x80F7 */ "PointerAnimationUsingKeyFrames", // Windows.UI.Xaml.Internal.PointerAnimationUsingKeyFrames
            /* 0x80F8 */ "PolyBezierSegment", // Windows.UI.Xaml.Media.PolyBezierSegment
            /* 0x80F9 */ "PolyLineSegment", // Windows.UI.Xaml.Media.PolyLineSegment
            /* 0x80FA */ "PolyQuadraticBezierSegment", // Windows.UI.Xaml.Media.PolyQuadraticBezierSegment
            /* 0x80FB */ "PopupThemeTransition", // Windows.UI.Xaml.Media.Animation.PopupThemeTransition
            /* 0x80FC */ "PowerEase", // Windows.UI.Xaml.Media.Animation.PowerEase
            /* 0x80FD */ "PVLStaggerFunction", // Windows.UI.Xaml.PVLStaggerFunction
            /* 0x80FE */ "QuadraticBezierSegment", // Windows.UI.Xaml.Media.QuadraticBezierSegment
            /* 0x80FF */ "QuadraticEase", // Windows.UI.Xaml.Media.Animation.QuadraticEase
            /* 0x8100 */ "QuarticEase", // Windows.UI.Xaml.Media.Animation.QuarticEase
            /* 0x8101 */ "QuinticEase", // Windows.UI.Xaml.Media.Animation.QuinticEase
            /* 0x8102 */ "RectangleGeometry", // Windows.UI.Xaml.Media.RectangleGeometry
            /* 0x8103 */ "RelativeSource", // Windows.UI.Xaml.Data.RelativeSource
            /* 0x8104 */ "RenderTargetBitmap", // Windows.UI.Xaml.Media.Imaging.RenderTargetBitmap
            /* 0x8105 */ "ReorderThemeTransition", // Windows.UI.Xaml.Media.Animation.ReorderThemeTransition
            /* 0x8106 */ "RepositionThemeTransition", // Windows.UI.Xaml.Media.Animation.RepositionThemeTransition
            /* 0x8107 */ "Setter", // Windows.UI.Xaml.Setter
            /* 0x8108 */ "SineEase", // Windows.UI.Xaml.Media.Animation.SineEase
            /* 0x8109 */ "SolidColorBrush", // Windows.UI.Xaml.Media.SolidColorBrush
            /* 0x810A */ "SplineColorKeyFrame", // Windows.UI.Xaml.Media.Animation.SplineColorKeyFrame
            /* 0x810B */ "SplineDoubleKeyFrame", // Windows.UI.Xaml.Media.Animation.SplineDoubleKeyFrame
            /* 0x810C */ "SplinePointKeyFrame", // Windows.UI.Xaml.Media.Animation.SplinePointKeyFrame
            /* 0x810D */ "StaticResource", // Windows.UI.Xaml.StaticResource
            /* 0x810E */ "SurfaceImageSource", // Windows.UI.Xaml.Media.Imaging.SurfaceImageSource
            /* 0x810F */ "SwapChainElement", // Windows.UI.Xaml.Internal.SwapChainElement
            /* 0x8110 */ "TemplateBinding", // Windows.UI.Xaml.Data.TemplateBinding
            /* 0x8111 */ "ThemeResource", // Windows.UI.Xaml.ThemeResource
            /* 0x8112 */ "TileBrush", // Windows.UI.Xaml.Media.TileBrush
            /* 0x8113 */ "Transform", // Windows.UI.Xaml.Media.Transform
            /* 0x8114 */ "VectorCollectionView", // Windows.UI.Xaml.Data.VectorCollectionView
            /* 0x8115 */ "VectorViewCollectionView", // Windows.UI.Xaml.Data.VectorViewCollectionView
            /* 0x8116 */ null,
            /* 0x8117 */ null,
            /* 0x8118 */ null,
            /* 0x8119 */ "AppBarAutomationPeer", // Windows.UI.Xaml.Automation.Peers.AppBarAutomationPeer
            /* 0x811A */ "AppBarLightDismissAutomationPeer", // Windows.UI.Xaml.Automation.Peers.AppBarLightDismissAutomationPeer
            /* 0x811B */ "AutomationPeerCollection", // Windows.UI.Xaml.Automation.Peers.AutomationPeerCollection
            /* 0x811C */ "AutoSuggestBoxAutomationPeer", // Windows.UI.Xaml.Automation.Peers.AutoSuggestBoxAutomationPeer
            /* 0x811D */ "BitmapImage", // Windows.UI.Xaml.Media.Imaging.BitmapImage
            /* 0x811E */ "Border", // Windows.UI.Xaml.Controls.Border
            /* 0x811F */ "ButtonBaseAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ButtonBaseAutomationPeer
            /* 0x8120 */ "CaptureElement", // Windows.UI.Xaml.Controls.CaptureElement
            /* 0x8121 */ "CaptureElementAutomationPeer", // Windows.UI.Xaml.Automation.Peers.CaptureElementAutomationPeer
            /* 0x8122 */ "ColorKeyFrameCollection", // Windows.UI.Xaml.Media.Animation.ColorKeyFrameCollection
            /* 0x8123 */ "ColumnDefinitionCollection", // Windows.UI.Xaml.Controls.ColumnDefinitionCollection
            /* 0x8124 */ "ComboBoxItemAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ComboBoxItemAutomationPeer
            /* 0x8125 */ "ComboBoxLightDismissAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ComboBoxLightDismissAutomationPeer
            /* 0x8126 */ "ComponentHost", // Windows.UI.Xaml.Internal.ComponentHost
            /* 0x8127 */ "CompositeTransform", // Windows.UI.Xaml.Media.CompositeTransform
            /* 0x8128 */ "ContentPresenter", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x8129 */ "Control", // Windows.UI.Xaml.Controls.Control
            /* 0x812A */ "DatePickerAutomationPeer", // Windows.UI.Xaml.Automation.Peers.DatePickerAutomationPeer
            /* 0x812B */ "DisplayMemberTemplate", // Windows.UI.Xaml.Internal.DisplayMemberTemplate
            /* 0x812C */ "DoubleCollection", // Windows.UI.Xaml.Media.DoubleCollection
            /* 0x812D */ "DoubleKeyFrameCollection", // Windows.UI.Xaml.Media.Animation.DoubleKeyFrameCollection
            /* 0x812E */ "DragItemThemeAnimation", // Windows.UI.Xaml.Media.Animation.DragItemThemeAnimation
            /* 0x812F */ "DragOverThemeAnimation", // Windows.UI.Xaml.Media.Animation.DragOverThemeAnimation
            /* 0x8130 */ "DropTargetItemThemeAnimation", // Windows.UI.Xaml.Media.Animation.DropTargetItemThemeAnimation
            /* 0x8131 */ "FaceplateContentPresenterAutomationPeer", // Windows.UI.Xaml.Automation.Peers.FaceplateContentPresenterAutomationPeer
            /* 0x8132 */ "FadeInThemeAnimation", // Windows.UI.Xaml.Media.Animation.FadeInThemeAnimation
            /* 0x8133 */ "FadeOutThemeAnimation", // Windows.UI.Xaml.Media.Animation.FadeOutThemeAnimation
            /* 0x8134 */ "FlipViewItemAutomationPeer", // Windows.UI.Xaml.Automation.Peers.FlipViewItemAutomationPeer
            /* 0x8135 */ "FloatCollection", // Windows.UI.Xaml.Media.FloatCollection
            /* 0x8136 */ "FlyoutPresenterAutomationPeer", // Windows.UI.Xaml.Automation.Peers.FlyoutPresenterAutomationPeer
            /* 0x8137 */ "GeometryCollection", // Windows.UI.Xaml.Media.GeometryCollection
            /* 0x8138 */ "Glyphs", // Windows.UI.Xaml.Documents.Glyphs
            /* 0x8139 */ "GradientStopCollection", // Windows.UI.Xaml.Media.GradientStopCollection
            /* 0x813A */ "GroupItemAutomationPeer", // Windows.UI.Xaml.Automation.Peers.GroupItemAutomationPeer
            /* 0x813B */ "HubAutomationPeer", // Windows.UI.Xaml.Automation.Peers.HubAutomationPeer
            /* 0x813C */ "HubSectionAutomationPeer", // Windows.UI.Xaml.Automation.Peers.HubSectionAutomationPeer
            /* 0x813D */ "HubSectionCollection", // Windows.UI.Xaml.Controls.HubSectionCollection
            /* 0x813E */ "HWCompMediaNode", // Windows.UI.Xaml.Internal.HWCompMediaNode
            /* 0x813F */ "HWCompRenderDataNode", // Windows.UI.Xaml.Internal.HWCompRenderDataNode
            /* 0x8140 */ "HWCompSwapChainNode", // Windows.UI.Xaml.Internal.HWCompSwapChainNode
            /* 0x8141 */ "HWCompTreeYCbCrNode", // Windows.UI.Xaml.Internal.HWCompTreeYCbCrNode
            /* 0x8142 */ "HWCompWebViewNode", // Windows.UI.Xaml.Internal.HWCompWebViewNode
            /* 0x8143 */ "HWCompYCbCrTextureNode", // Windows.UI.Xaml.Internal.HWCompYCbCrTextureNode
            /* 0x8144 */ "HWRedirectedCompTreeNode", // Windows.UI.Xaml.Internal.HWRedirectedCompTreeNode
            /* 0x8145 */ "IconElement", // Windows.UI.Xaml.Controls.IconElement
            /* 0x8146 */ "Image", // Windows.UI.Xaml.Controls.Image
            /* 0x8147 */ "ImageAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ImageAutomationPeer
            /* 0x8148 */ "ImageBrush", // Windows.UI.Xaml.Media.ImageBrush
            /* 0x8149 */ "InlineUIContainer", // Windows.UI.Xaml.Documents.InlineUIContainer
            /* 0x814A */ "InputScopeNameCollection", // Windows.UI.Xaml.Input.InputScopeNameCollection
            /* 0x814B */ "ItemsControlAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ItemsControlAutomationPeer
            /* 0x814C */ "ItemsPresenter", // Windows.UI.Xaml.Controls.ItemsPresenter
            /* 0x814D */ "IterableCollectionView", // Windows.UI.Xaml.Data.IterableCollectionView
            /* 0x814E */ "LinearGradientBrush", // Windows.UI.Xaml.Media.LinearGradientBrush
            /* 0x814F */ "LineBreak", // Windows.UI.Xaml.Documents.LineBreak
            /* 0x8150 */ "ListBoxItemAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ListBoxItemAutomationPeer
            /* 0x8151 */ "ListViewBaseHeaderItemAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ListViewBaseHeaderItemAutomationPeer
            /* 0x8152 */ "ListViewBaseItemAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ListViewBaseItemAutomationPeer
            /* 0x8153 */ "ListViewBaseItemSecondaryChrome", // Windows.UI.Xaml.Controls.Primitives.ListViewBaseItemSecondaryChrome
            /* 0x8154 */ "MatrixTransform", // Windows.UI.Xaml.Media.MatrixTransform
            /* 0x8155 */ "MediaBase", // Windows.UI.Xaml.Internal.MediaBase
            /* 0x8156 */ "MediaElement", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8157 */ "MediaElementAutomationPeer", // Windows.UI.Xaml.Automation.Peers.MediaElementAutomationPeer
            /* 0x8158 */ "MediaTransportControlsAutomationPeer", // Windows.UI.Xaml.Automation.Peers.MediaTransportControlsAutomationPeer
            /* 0x8159 */ "MenuFlyoutItemAutomationPeer", // Windows.UI.Xaml.Automation.Peers.MenuFlyoutItemAutomationPeer
            /* 0x815A */ "MenuFlyoutItemBaseCollection", // Windows.UI.Xaml.Controls.MenuFlyoutItemBaseCollection
            /* 0x815B */ "ObjectKeyFrameCollection", // Windows.UI.Xaml.Media.Animation.ObjectKeyFrameCollection
            /* 0x815C */ "Panel", // Windows.UI.Xaml.Controls.Panel
            /* 0x815D */ "Paragraph", // Windows.UI.Xaml.Documents.Paragraph
            /* 0x815E */ "ParametricCurveCollection", // Windows.UI.Xaml.Internal.ParametricCurveCollection
            /* 0x815F */ "ParametricCurveSegmentCollection", // Windows.UI.Xaml.Internal.ParametricCurveSegmentCollection
            /* 0x8160 */ "PasswordBoxAutomationPeer", // Windows.UI.Xaml.Automation.Peers.PasswordBoxAutomationPeer
            /* 0x8161 */ "PathFigureCollection", // Windows.UI.Xaml.Media.PathFigureCollection
            /* 0x8162 */ "PathSegmentCollection", // Windows.UI.Xaml.Media.PathSegmentCollection
            /* 0x8163 */ "PointCollection", // Windows.UI.Xaml.Media.PointCollection
            /* 0x8164 */ "PointerCollection", // Windows.UI.Xaml.Input.PointerCollection
            /* 0x8165 */ "PointerDownThemeAnimation", // Windows.UI.Xaml.Media.Animation.PointerDownThemeAnimation
            /* 0x8166 */ "PointerKeyFrameCollection", // Windows.UI.Xaml.Internal.PointerKeyFrameCollection
            /* 0x8167 */ "PointerUpThemeAnimation", // Windows.UI.Xaml.Media.Animation.PointerUpThemeAnimation
            /* 0x8168 */ "PointKeyFrameCollection", // Windows.UI.Xaml.Media.Animation.PointKeyFrameCollection
            /* 0x8169 */ "PopInThemeAnimation", // Windows.UI.Xaml.Media.Animation.PopInThemeAnimation
            /* 0x816A */ "PopOutThemeAnimation", // Windows.UI.Xaml.Media.Animation.PopOutThemeAnimation
            /* 0x816B */ "Popup", // Windows.UI.Xaml.Controls.Primitives.Popup
            /* 0x816C */ "PopupAutomationPeer", // Windows.UI.Xaml.Automation.Peers.PopupAutomationPeer
            /* 0x816D */ "PopupRootAutomationPeer", // Windows.UI.Xaml.Automation.Peers.PopupRootAutomationPeer
            /* 0x816E */ "ProgressRingAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ProgressRingAutomationPeer
            /* 0x816F */ "RadialGradientBrush", // Windows.UI.Xaml.Media.RadialGradientBrush
            /* 0x8170 */ "RangeBaseAutomationPeer", // Windows.UI.Xaml.Automation.Peers.RangeBaseAutomationPeer
            /* 0x8171 */ "RepeatBehavior", // Windows.UI.Xaml.Media.Animation.RepeatBehavior
            /* 0x8172 */ "RepositionThemeAnimation", // Windows.UI.Xaml.Media.Animation.RepositionThemeAnimation
            /* 0x8173 */ "ResourceDictionary", // Windows.UI.Xaml.ResourceDictionary
            /* 0x8174 */ "ResourceDictionaryCollection", // Windows.UI.Xaml.Internal.ResourceDictionaryCollection
            /* 0x8175 */ "RichEditBoxAutomationPeer", // Windows.UI.Xaml.Automation.Peers.RichEditBoxAutomationPeer
            /* 0x8176 */ "RichTextBlock", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x8177 */ "RichTextBlockAutomationPeer", // Windows.UI.Xaml.Automation.Peers.RichTextBlockAutomationPeer
            /* 0x8178 */ "RichTextBlockOverflow", // Windows.UI.Xaml.Controls.RichTextBlockOverflow
            /* 0x8179 */ "RichTextBlockOverflowAutomationPeer", // Windows.UI.Xaml.Automation.Peers.RichTextBlockOverflowAutomationPeer
            /* 0x817A */ "RotateTransform", // Windows.UI.Xaml.Media.RotateTransform
            /* 0x817B */ "RowDefinitionCollection", // Windows.UI.Xaml.Controls.RowDefinitionCollection
            /* 0x817C */ "Run", // Windows.UI.Xaml.Documents.Run
            /* 0x817D */ "ScaleTransform", // Windows.UI.Xaml.Media.ScaleTransform
            /* 0x817E */ "ScrollViewerAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ScrollViewerAutomationPeer
            /* 0x817F */ "SearchBoxAutomationPeer", // Windows.UI.Xaml.Automation.Peers.SearchBoxAutomationPeer
            /* 0x8180 */ "SelectorItemAutomationPeer", // Windows.UI.Xaml.Automation.Peers.SelectorItemAutomationPeer
            /* 0x8181 */ "SemanticZoomAutomationPeer", // Windows.UI.Xaml.Automation.Peers.SemanticZoomAutomationPeer
            /* 0x8182 */ "SetterBaseCollection", // Windows.UI.Xaml.SetterBaseCollection
            /* 0x8183 */ "SettingsFlyoutAutomationPeer", // Windows.UI.Xaml.Automation.Peers.SettingsFlyoutAutomationPeer
            /* 0x8184 */ "Shape", // Windows.UI.Xaml.Shapes.Shape
            /* 0x8185 */ "SkewTransform", // Windows.UI.Xaml.Media.SkewTransform
            /* 0x8186 */ "Span", // Windows.UI.Xaml.Documents.Span
            /* 0x8187 */ "SplitCloseThemeAnimation", // Windows.UI.Xaml.Media.Animation.SplitCloseThemeAnimation
            /* 0x8188 */ "SplitOpenThemeAnimation", // Windows.UI.Xaml.Media.Animation.SplitOpenThemeAnimation
            /* 0x8189 */ "Storyboard", // Windows.UI.Xaml.Media.Animation.Storyboard
            /* 0x818A */ "SwipeBackThemeAnimation", // Windows.UI.Xaml.Media.Animation.SwipeBackThemeAnimation
            /* 0x818B */ "SwipeHintThemeAnimation", // Windows.UI.Xaml.Media.Animation.SwipeHintThemeAnimation
            /* 0x818C */ "TextBlock", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x818D */ "TextBlockAutomationPeer", // Windows.UI.Xaml.Automation.Peers.TextBlockAutomationPeer
            /* 0x818E */ "TextBoxAutomationPeer", // Windows.UI.Xaml.Automation.Peers.TextBoxAutomationPeer
            /* 0x818F */ "TextBoxBaseAutomationPeer", // Windows.UI.Xaml.Automation.Peers.TextBoxBaseAutomationPeer
            /* 0x8190 */ "TextBoxView", // Windows.UI.Xaml.Internal.TextBoxView
            /* 0x8191 */ "TextElementCollection", // Windows.UI.Xaml.Documents.TextElementCollection
            /* 0x8192 */ "ThemeAnimationBase", // Windows.UI.Xaml.Media.Animation.ThemeAnimationBase
            /* 0x8193 */ "ThumbAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ThumbAutomationPeer
            /* 0x8194 */ "TimelineCollection", // Windows.UI.Xaml.Media.Animation.TimelineCollection
            /* 0x8195 */ "TimelineMarkerCollection", // Windows.UI.Xaml.Media.TimelineMarkerCollection
            /* 0x8196 */ "TimePickerAutomationPeer", // Windows.UI.Xaml.Automation.Peers.TimePickerAutomationPeer
            /* 0x8197 */ "ToggleMenuFlyoutItemAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ToggleMenuFlyoutItemAutomationPeer
            /* 0x8198 */ "ToggleSwitchAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ToggleSwitchAutomationPeer
            /* 0x8199 */ "ToolTipAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ToolTipAutomationPeer
            /* 0x819A */ "TransformCollection", // Windows.UI.Xaml.Media.TransformCollection
            /* 0x819B */ "TransformGroup", // Windows.UI.Xaml.Media.TransformGroup
            /* 0x819C */ "TransitionCollection", // Windows.UI.Xaml.Media.Animation.TransitionCollection
            /* 0x819D */ "TranslateTransform", // Windows.UI.Xaml.Media.TranslateTransform
            /* 0x819E */ "TriggerActionCollection", // Windows.UI.Xaml.TriggerActionCollection
            /* 0x819F */ "TriggerCollection", // Windows.UI.Xaml.TriggerCollection
            /* 0x81A0 */ "UIElementCollection", // Windows.UI.Xaml.Controls.UIElementCollection
            /* 0x81A1 */ "Viewbox", // Windows.UI.Xaml.Controls.Viewbox
            /* 0x81A2 */ "VirtualSurfaceImageSource", // Windows.UI.Xaml.Media.Imaging.VirtualSurfaceImageSource
            /* 0x81A3 */ "VisualStateCollection", // Windows.UI.Xaml.Internal.VisualStateCollection
            /* 0x81A4 */ "VisualStateGroupCollection", // Windows.UI.Xaml.Internal.VisualStateGroupCollection
            /* 0x81A5 */ "VisualTransitionCollection", // Windows.UI.Xaml.Internal.VisualTransitionCollection
            /* 0x81A6 */ "WebViewAutomationPeer", // Windows.UI.Xaml.Automation.Peers.WebViewAutomationPeer
            /* 0x81A7 */ "WebViewBrush", // Windows.UI.Xaml.Controls.WebViewBrush
            /* 0x81A8 */ "WriteableBitmap", // Windows.UI.Xaml.Media.Imaging.WriteableBitmap
            /* 0x81A9 */ null,
            /* 0x81AA */ null,
            /* 0x81AB */ "AppBarSeparator", // Windows.UI.Xaml.Controls.AppBarSeparator
            /* 0x81AC */ "BasedOnSetterCollection", // Windows.UI.Xaml.BasedOnSetterCollection
            /* 0x81AD */ "BitmapIcon", // Windows.UI.Xaml.Controls.BitmapIcon
            /* 0x81AE */ "Bold", // Windows.UI.Xaml.Documents.Bold
            /* 0x81AF */ "ButtonAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ButtonAutomationPeer
            /* 0x81B0 */ "Canvas", // Windows.UI.Xaml.Controls.Canvas
            /* 0x81B1 */ "ComboBoxItemDataAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ComboBoxItemDataAutomationPeer
            /* 0x81B2 */ "CommandBarElementCollection", // Windows.UI.Xaml.Controls.CommandBarElementCollection
            /* 0x81B3 */ "ContentControl", // Windows.UI.Xaml.Controls.ContentControl
            /* 0x81B4 */ "DatePicker", // Windows.UI.Xaml.Controls.DatePicker
            /* 0x81B5 */ "DependencyObjectCollection", // Windows.UI.Xaml.DependencyObjectCollection
            /* 0x81B6 */ "Ellipse", // Windows.UI.Xaml.Shapes.Ellipse
            /* 0x81B7 */ "FlipViewItemDataAutomationPeer", // Windows.UI.Xaml.Automation.Peers.FlipViewItemDataAutomationPeer
            /* 0x81B8 */ "FontIcon", // Windows.UI.Xaml.Controls.FontIcon
            /* 0x81B9 */ "FullWindowMediaRoot", // Windows.UI.Xaml.FullWindowMediaRoot
            /* 0x81BA */ "Grid", // Windows.UI.Xaml.Controls.Grid
            /* 0x81BB */ "GridViewHeaderItemAutomationPeer", // Windows.UI.Xaml.Automation.Peers.GridViewHeaderItemAutomationPeer
            /* 0x81BC */ "GridViewItemAutomationPeer", // Windows.UI.Xaml.Automation.Peers.GridViewItemAutomationPeer
            /* 0x81BD */ "Hub", // Windows.UI.Xaml.Controls.Hub
            /* 0x81BE */ "HubSection", // Windows.UI.Xaml.Controls.HubSection
            /* 0x81BF */ "Hyperlink", // Windows.UI.Xaml.Documents.Hyperlink
            /* 0x81C0 */ "HyperlinkButtonAutomationPeer", // Windows.UI.Xaml.Automation.Peers.HyperlinkButtonAutomationPeer
            /* 0x81C1 */ "Italic", // Windows.UI.Xaml.Documents.Italic
            /* 0x81C2 */ "ItemCollection", // Windows.UI.Xaml.Controls.ItemCollection
            /* 0x81C3 */ "ItemsControl", // Windows.UI.Xaml.Controls.ItemsControl
            /* 0x81C4 */ "Line", // Windows.UI.Xaml.Shapes.Line
            /* 0x81C5 */ "ListBoxItemDataAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ListBoxItemDataAutomationPeer
            /* 0x81C6 */ "ListViewBaseItemDataAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ListViewBaseItemDataAutomationPeer
            /* 0x81C7 */ "ListViewBaseItemPresenter", // Windows.UI.Xaml.Controls.Primitives.ListViewBaseItemPresenter
            /* 0x81C8 */ "ListViewHeaderItemAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ListViewHeaderItemAutomationPeer
            /* 0x81C9 */ "ListViewItemAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ListViewItemAutomationPeer
            /* 0x81CA */ "MediaTransportControls", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x81CB */ "MenuFlyoutItemBase", // Windows.UI.Xaml.Controls.MenuFlyoutItemBase
            /* 0x81CC */ "MenuFlyoutPresenterAutomationPeer", // Windows.UI.Xaml.Automation.Peers.MenuFlyoutPresenterAutomationPeer
            /* 0x81CD */ "ModernCollectionBasePanel", // Windows.UI.Xaml.Controls.ModernCollectionBasePanel
            /* 0x81CE */ "PasswordBox", // Windows.UI.Xaml.Controls.PasswordBox
            /* 0x81CF */ "Path", // Windows.UI.Xaml.Shapes.Path
            /* 0x81D0 */ "PathIcon", // Windows.UI.Xaml.Controls.PathIcon
            /* 0x81D1 */ "Polygon", // Windows.UI.Xaml.Shapes.Polygon
            /* 0x81D2 */ "Polyline", // Windows.UI.Xaml.Shapes.Polyline
            /* 0x81D3 */ "ProgressBarAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ProgressBarAutomationPeer
            /* 0x81D4 */ "ProgressRing", // Windows.UI.Xaml.Controls.ProgressRing
            /* 0x81D5 */ "RangeBase", // Windows.UI.Xaml.Controls.Primitives.RangeBase
            /* 0x81D6 */ "Rectangle", // Windows.UI.Xaml.Shapes.Rectangle
            /* 0x81D7 */ "RenderTargetBitmapRoot", // Windows.UI.Xaml.RenderTargetBitmapRoot
            /* 0x81D8 */ "RepeatButtonAutomationPeer", // Windows.UI.Xaml.Automation.Peers.RepeatButtonAutomationPeer
            /* 0x81D9 */ "RichEditBox", // Windows.UI.Xaml.Controls.RichEditBox
            /* 0x81DA */ "RootVisual", // Windows.UI.Xaml.RootVisual
            /* 0x81DB */ "ScrollBarAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ScrollBarAutomationPeer
            /* 0x81DC */ "ScrollContentPresenter", // Windows.UI.Xaml.Controls.ScrollContentPresenter
            /* 0x81DD */ "SearchBox", // Windows.UI.Xaml.Controls.SearchBox
            /* 0x81DE */ "SelectorAutomationPeer", // Windows.UI.Xaml.Automation.Peers.SelectorAutomationPeer
            /* 0x81DF */ "SemanticZoom", // Windows.UI.Xaml.Controls.SemanticZoom
            /* 0x81E0 */ "SliderAutomationPeer", // Windows.UI.Xaml.Automation.Peers.SliderAutomationPeer
            /* 0x81E1 */ "StackPanel", // Windows.UI.Xaml.Controls.StackPanel
            /* 0x81E2 */ "SymbolIcon", // Windows.UI.Xaml.Controls.SymbolIcon
            /* 0x81E3 */ "TextBox", // Windows.UI.Xaml.Controls.TextBox
            /* 0x81E4 */ "TextBoxBase", // Windows.UI.Xaml.Internal.TextBoxBase
            /* 0x81E5 */ "Thumb", // Windows.UI.Xaml.Controls.Primitives.Thumb
            /* 0x81E6 */ "TickBar", // Windows.UI.Xaml.Controls.Primitives.TickBar
            /* 0x81E7 */ "TimePicker", // Windows.UI.Xaml.Controls.TimePicker
            /* 0x81E8 */ "ToggleButtonAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ToggleButtonAutomationPeer
            /* 0x81E9 */ "ToggleSwitch", // Windows.UI.Xaml.Controls.ToggleSwitch
            /* 0x81EA */ "Underline", // Windows.UI.Xaml.Documents.Underline
            /* 0x81EB */ "UserControl", // Windows.UI.Xaml.Controls.UserControl
            /* 0x81EC */ "VariableSizedWrapGrid", // Windows.UI.Xaml.Controls.VariableSizedWrapGrid
            /* 0x81ED */ "VirtualizingPanel", // Windows.UI.Xaml.Controls.VirtualizingPanel
            /* 0x81EE */ "WebView", // Windows.UI.Xaml.Controls.WebView
            /* 0x81EF */ "AppBar", // Windows.UI.Xaml.Controls.AppBar
            /* 0x81F0 */ "AppBarButtonAutomationPeer", // Windows.UI.Xaml.Automation.Peers.AppBarButtonAutomationPeer
            /* 0x81F1 */ "AppBarLightDismiss", // Windows.UI.Xaml.Controls.AppBarLightDismiss
            /* 0x81F2 */ "AppBarToggleButtonAutomationPeer", // Windows.UI.Xaml.Automation.Peers.AppBarToggleButtonAutomationPeer
            /* 0x81F3 */ "AutoSuggestBox", // Windows.UI.Xaml.Controls.AutoSuggestBox
            /* 0x81F4 */ "BlockCollection", // Windows.UI.Xaml.Documents.BlockCollection
            /* 0x81F5 */ "ButtonBase", // Windows.UI.Xaml.Controls.Primitives.ButtonBase
            /* 0x81F6 */ "CarouselPanel", // Windows.UI.Xaml.Controls.Primitives.CarouselPanel
            /* 0x81F7 */ "CheckBoxAutomationPeer", // Windows.UI.Xaml.Automation.Peers.CheckBoxAutomationPeer
            /* 0x81F8 */ "ComboBoxAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ComboBoxAutomationPeer
            /* 0x81F9 */ "ComboBoxLightDismiss", // Windows.UI.Xaml.Controls.ComboBoxLightDismiss
            /* 0x81FA */ "ContentDialog", // Windows.UI.Xaml.Controls.ContentDialog
            /* 0x81FB */ "FlipViewAutomationPeer", // Windows.UI.Xaml.Automation.Peers.FlipViewAutomationPeer
            /* 0x81FC */ "FlyoutPresenter", // Windows.UI.Xaml.Controls.FlyoutPresenter
            /* 0x81FD */ "Frame", // Windows.UI.Xaml.Controls.Frame
            /* 0x81FE */ "GridViewItemDataAutomationPeer", // Windows.UI.Xaml.Automation.Peers.GridViewItemDataAutomationPeer
            /* 0x81FF */ "GridViewItemPresenter", // Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter
            /* 0x8200 */ "GroupItem", // Windows.UI.Xaml.Controls.GroupItem
            /* 0x8201 */ "InlineCollection", // Windows.UI.Xaml.Documents.InlineCollection
            /* 0x8202 */ "ItemsStackPanel", // Windows.UI.Xaml.Controls.ItemsStackPanel
            /* 0x8203 */ "ItemsWrapGrid", // Windows.UI.Xaml.Controls.ItemsWrapGrid
            /* 0x8204 */ "ListBoxAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ListBoxAutomationPeer
            /* 0x8205 */ "ListViewBaseAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ListViewBaseAutomationPeer
            /* 0x8206 */ "ListViewBaseHeaderItem", // Windows.UI.Xaml.Controls.ListViewBaseHeaderItem
            /* 0x8207 */ "ListViewItemDataAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ListViewItemDataAutomationPeer
            /* 0x8208 */ "ListViewItemPresenter", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x8209 */ "MenuFlyoutItem", // Windows.UI.Xaml.Controls.MenuFlyoutItem
            /* 0x820A */ "MenuFlyoutPresenter", // Windows.UI.Xaml.Controls.MenuFlyoutPresenter
            /* 0x820B */ "MenuFlyoutSeparator", // Windows.UI.Xaml.Controls.MenuFlyoutSeparator
            /* 0x820C */ "OrientedVirtualizingPanel", // Windows.UI.Xaml.Controls.Primitives.OrientedVirtualizingPanel
            /* 0x820D */ "Page", // Windows.UI.Xaml.Controls.Page
            /* 0x820E */ "PopupRoot", // Windows.UI.Xaml.PopupRoot
            /* 0x820F */ "PrintRoot", // Windows.UI.Xaml.PrintRoot
            /* 0x8210 */ "ProgressBar", // Windows.UI.Xaml.Controls.ProgressBar
            /* 0x8211 */ "RadioButtonAutomationPeer", // Windows.UI.Xaml.Automation.Peers.RadioButtonAutomationPeer
            /* 0x8212 */ "ScrollBar", // Windows.UI.Xaml.Controls.Primitives.ScrollBar
            /* 0x8213 */ "ScrollContentControl", // Windows.UI.Xaml.Controls.ScrollContentControl
            /* 0x8214 */ "SelectorItem", // Windows.UI.Xaml.Controls.Primitives.SelectorItem
            /* 0x8215 */ "SettingsFlyout", // Windows.UI.Xaml.Controls.SettingsFlyout
            /* 0x8216 */ "Slider", // Windows.UI.Xaml.Controls.Slider
            /* 0x8217 */ "SwapChainBackgroundPanel", // Windows.UI.Xaml.Controls.SwapChainBackgroundPanel
            /* 0x8218 */ "SwapChainPanel", // Windows.UI.Xaml.Controls.SwapChainPanel
            /* 0x8219 */ "TextSelectionGripper", // Windows.UI.Xaml.Internal.TextSelectionGripper
            /* 0x821A */ "ToolTip", // Windows.UI.Xaml.Controls.ToolTip
            /* 0x821B */ "TransitionRoot", // Windows.UI.Xaml.TransitionRoot
            /* 0x821C */ "Button", // Windows.UI.Xaml.Controls.Button
            /* 0x821D */ "ComboBoxItem", // Windows.UI.Xaml.Controls.ComboBoxItem
            /* 0x821E */ "CommandBar", // Windows.UI.Xaml.Controls.CommandBar
            /* 0x821F */ "FlipViewItem", // Windows.UI.Xaml.Controls.FlipViewItem
            /* 0x8220 */ "GridViewAutomationPeer", // Windows.UI.Xaml.Automation.Peers.GridViewAutomationPeer
            /* 0x8221 */ "GridViewHeaderItem", // Windows.UI.Xaml.Controls.GridViewHeaderItem
            /* 0x8222 */ "HyperlinkButton", // Windows.UI.Xaml.Controls.HyperlinkButton
            /* 0x8223 */ "ListBoxItem", // Windows.UI.Xaml.Controls.ListBoxItem
            /* 0x8224 */ "ListViewAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ListViewAutomationPeer
            /* 0x8225 */ "ListViewBaseItem", // Windows.UI.Xaml.Controls.ListViewBaseItem
            /* 0x8226 */ "ListViewHeaderItem", // Windows.UI.Xaml.Controls.ListViewHeaderItem
            /* 0x8227 */ "RepeatButton", // Windows.UI.Xaml.Controls.Primitives.RepeatButton
            /* 0x8228 */ "ScrollViewer", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x8229 */ "ToggleButton", // Windows.UI.Xaml.Controls.Primitives.ToggleButton
            /* 0x822A */ "ToggleMenuFlyoutItem", // Windows.UI.Xaml.Controls.ToggleMenuFlyoutItem
            /* 0x822B */ "VirtualizingStackPanel", // Windows.UI.Xaml.Controls.VirtualizingStackPanel
            /* 0x822C */ "WrapGrid", // Windows.UI.Xaml.Controls.WrapGrid
            /* 0x822D */ "AppBarButton", // Windows.UI.Xaml.Controls.AppBarButton
            /* 0x822E */ "AppBarToggleButton", // Windows.UI.Xaml.Controls.AppBarToggleButton
            /* 0x822F */ "CheckBox", // Windows.UI.Xaml.Controls.CheckBox
            /* 0x8230 */ "GridViewItem", // Windows.UI.Xaml.Controls.GridViewItem
            /* 0x8231 */ "ListViewItem", // Windows.UI.Xaml.Controls.ListViewItem
            /* 0x8232 */ "RadioButton", // Windows.UI.Xaml.Controls.RadioButton
            /* 0x8233 */ "RootScrollViewer", // Windows.UI.Xaml.Internal.RootScrollViewer
            /* 0x8234 */ "Binding", // Windows.UI.Xaml.Data.Binding
            /* 0x8235 */ "Selector", // Windows.UI.Xaml.Controls.Primitives.Selector
            /* 0x8236 */ "ComboBox", // Windows.UI.Xaml.Controls.ComboBox
            /* 0x8237 */ "FlipView", // Windows.UI.Xaml.Controls.FlipView
            /* 0x8238 */ "ListBox", // Windows.UI.Xaml.Controls.ListBox
            /* 0x8239 */ "ListViewBase", // Windows.UI.Xaml.Controls.ListViewBase
            /* 0x823A */ "GridView", // Windows.UI.Xaml.Controls.GridView
            /* 0x823B */ "ListView", // Windows.UI.Xaml.Controls.ListView
            /* 0x823C */ "AccessibilityView", // Windows.UI.Xaml.Automation.Peers.AccessibilityView
            /* 0x823D */ "AlignmentX", // Windows.UI.Xaml.Media.AlignmentX
            /* 0x823E */ "AlignmentY", // Windows.UI.Xaml.Media.AlignmentY
            /* 0x823F */ "AnimationDirection", // Windows.UI.Xaml.Controls.Primitives.AnimationDirection
            /* 0x8240 */ "AnnotationType", // Windows.UI.Xaml.Automation.AnnotationType
            /* 0x8241 */ "AppBarClosedDisplayMode", // Windows.UI.Xaml.Controls.AppBarClosedDisplayMode
            /* 0x8242 */ "ApplicationTheme", // Windows.UI.Xaml.ApplicationTheme
            /* 0x8243 */ "AudioCategory", // Windows.UI.Xaml.Media.AudioCategory
            /* 0x8244 */ "AudioDeviceType", // Windows.UI.Xaml.Media.AudioDeviceType
            /* 0x8245 */ "AutomationControlType", // Windows.UI.Xaml.Automation.Peers.AutomationControlType
            /* 0x8246 */ "AutomationEvents", // Windows.UI.Xaml.Automation.Peers.AutomationEvents
            /* 0x8247 */ "AutomationLiveSetting", // Windows.UI.Xaml.Automation.Peers.AutomationLiveSetting
            /* 0x8248 */ "AutomationOrientation", // Windows.UI.Xaml.Automation.Peers.AutomationOrientation
            /* 0x8249 */ "AutoSuggestionBoxTextChangeReason", // Windows.UI.Xaml.Controls.AutoSuggestionBoxTextChangeReason
            /* 0x824A */ "BindingMode", // Windows.UI.Xaml.Data.BindingMode
            /* 0x824B */ "BitmapCreateOptions", // Windows.UI.Xaml.Media.Imaging.BitmapCreateOptions
            /* 0x824C */ "BrushMappingMode", // Windows.UI.Xaml.Media.BrushMappingMode
            /* 0x824D */ "ClickMode", // Windows.UI.Xaml.Controls.ClickMode
            /* 0x824E */ "ClockState", // Windows.UI.Xaml.Media.Animation.ClockState
            /* 0x824F */ null,
            /* 0x8250 */ "CollectionChange", // Windows.Foundation.Collections.CollectionChange
            /* 0x8251 */ "ColorInterpolationMode", // Windows.UI.Xaml.Media.ColorInterpolationMode
            /* 0x8252 */ "ComponentResourceLocation", // Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation
            /* 0x8253 */ "ContentDialogResult", // Windows.UI.Xaml.Controls.ContentDialogResult
            /* 0x8254 */ "DecodePixelType", // Windows.UI.Xaml.Media.Imaging.DecodePixelType
            /* 0x8255 */ "DockPosition", // Windows.UI.Xaml.Automation.DockPosition
            /* 0x8256 */ "EasingMode", // Windows.UI.Xaml.Media.Animation.EasingMode
            /* 0x8257 */ "EdgeTransitionLocation", // Windows.UI.Xaml.Controls.Primitives.EdgeTransitionLocation
            /* 0x8258 */ "ElementCompositeMode", // Windows.UI.Xaml.Media.ElementCompositeMode
            /* 0x8259 */ "ElementTheme", // Windows.UI.Xaml.ElementTheme
            /* 0x825A */ "ExpandCollapseState", // Windows.UI.Xaml.Automation.ExpandCollapseState
            /* 0x825B */ "FillBehavior", // Windows.UI.Xaml.Media.Animation.FillBehavior
            /* 0x825C */ "FillRule", // Windows.UI.Xaml.Media.FillRule
            /* 0x825D */ "FlowDirection", // Windows.UI.Xaml.FlowDirection
            /* 0x825E */ "FlyoutPlacementMode", // Windows.UI.Xaml.Controls.Primitives.FlyoutPlacementMode
            /* 0x825F */ "FocusNavigationDirection", // Windows.UI.Xaml.Input.FocusNavigationDirection
            /* 0x8260 */ "FocusState", // Windows.UI.Xaml.FocusState
            /* 0x8261 */ "FontCapitals", // Windows.UI.Xaml.FontCapitals
            /* 0x8262 */ "FontEastAsianLanguage", // Windows.UI.Xaml.FontEastAsianLanguage
            /* 0x8263 */ "FontEastAsianWidths", // Windows.UI.Xaml.FontEastAsianWidths
            /* 0x8264 */ "FontFraction", // Windows.UI.Xaml.FontFraction
            /* 0x8265 */ "FontNumeralAlignment", // Windows.UI.Xaml.FontNumeralAlignment
            /* 0x8266 */ "FontNumeralStyle", // Windows.UI.Xaml.FontNumeralStyle
            /* 0x8267 */ "FontStretch", // Windows.UI.Text.FontStretch
            /* 0x8268 */ "FontStyle", // Windows.UI.Text.FontStyle
            /* 0x8269 */ "FontVariants", // Windows.UI.Xaml.FontVariants
            /* 0x826A */ "GeneratorDirection", // Windows.UI.Xaml.Controls.Primitives.GeneratorDirection
            /* 0x826B */ "GestureModes", // Windows.UI.Xaml.Input.GestureModes
            /* 0x826C */ "GradientSpreadMethod", // Windows.UI.Xaml.Media.GradientSpreadMethod
            /* 0x826D */ "GridUnitType", // Windows.UI.Xaml.GridUnitType
            /* 0x826E */ "GroupHeaderPlacement", // Windows.UI.Xaml.Controls.Primitives.GroupHeaderPlacement
            /* 0x826F */ "HoldingState", // Windows.UI.Input.HoldingState
            /* 0x8270 */ "HorizontalAlignment", // Windows.UI.Xaml.HorizontalAlignment
            /* 0x8271 */ "IncrementalLoadingTrigger", // Windows.UI.Xaml.Controls.IncrementalLoadingTrigger
            /* 0x8272 */ "InputScopeNameValue", // Windows.UI.Xaml.Input.InputScopeNameValue
            /* 0x8273 */ "ItemsUpdatingScrollMode", // Windows.UI.Xaml.Controls.ItemsUpdatingScrollMode
            /* 0x8274 */ "KeyboardNavigationMode", // Windows.UI.Xaml.Input.KeyboardNavigationMode
            /* 0x8275 */ "LineStackingStrategy", // Windows.UI.Xaml.LineStackingStrategy
            /* 0x8276 */ "ListViewReorderMode", // Windows.UI.Xaml.Controls.ListViewReorderMode
            /* 0x8277 */ "ListViewSelectionMode", // Windows.UI.Xaml.Controls.ListViewSelectionMode
            /* 0x8278 */ "LogicalDirection", // Windows.UI.Xaml.Documents.LogicalDirection
            /* 0x8279 */ "ManipulationModes", // Windows.UI.Xaml.Input.ManipulationModes
            /* 0x827A */ "MarkupExtensionType", // Windows.UI.Xaml.MarkupExtensionType
            /* 0x827B */ "MediaCanPlayResponse", // Windows.UI.Xaml.Media.MediaCanPlayResponse
            /* 0x827C */ "MediaElementState", // Windows.UI.Xaml.Media.MediaElementState
            /* 0x827D */ "NavigationCacheMode", // Windows.UI.Xaml.Navigation.NavigationCacheMode
            /* 0x827E */ "NavigationMode", // Windows.UI.Xaml.Navigation.NavigationMode
            /* 0x827F */ "NotifyCollectionChangedAction", // Windows.UI.Xaml.Interop.NotifyCollectionChangedAction
            /* 0x8280 */ "OpticalMarginAlignment", // Windows.UI.Xaml.OpticalMarginAlignment
            /* 0x8281 */ "Orientation", // Windows.UI.Xaml.Controls.Orientation
            /* 0x8282 */ "PanelScrollingDirection", // Windows.UI.Xaml.Controls.PanelScrollingDirection
            /* 0x8283 */ "PatternInterface", // Windows.UI.Xaml.Automation.Peers.PatternInterface
            /* 0x8284 */ "PenLineCap", // Windows.UI.Xaml.Media.PenLineCap
            /* 0x8285 */ "PenLineJoin", // Windows.UI.Xaml.Media.PenLineJoin
            /* 0x8286 */ "PlacementMode", // Windows.UI.Xaml.Controls.Primitives.PlacementMode
            /* 0x8287 */ "PointerDeviceType", // Windows.Devices.Input.PointerDeviceType
            /* 0x8288 */ "PointerDirection", // Windows.UI.Xaml.Internal.PointerDirection
            /* 0x8289 */ "PreviewPageCountType", // Windows.UI.Xaml.Printing.PreviewPageCountType
            /* 0x828A */ "PrintDocumentFormat", // Windows.UI.Xaml.Printing.PrintDocumentFormat
            /* 0x828B */ "RelativeSourceMode", // Windows.UI.Xaml.Data.RelativeSourceMode
            /* 0x828C */ "RowOrColumnMajor", // Windows.UI.Xaml.Automation.RowOrColumnMajor
            /* 0x828D */ "ScrollAmount", // Windows.UI.Xaml.Automation.ScrollAmount
            /* 0x828E */ "ScrollBarVisibility", // Windows.UI.Xaml.Controls.ScrollBarVisibility
            /* 0x828F */ "ScrollEventType", // Windows.UI.Xaml.Controls.Primitives.ScrollEventType
            /* 0x8290 */ "ScrollingIndicatorMode", // Windows.UI.Xaml.Controls.Primitives.ScrollingIndicatorMode
            /* 0x8291 */ "ScrollIntoViewAlignment", // Windows.UI.Xaml.Controls.ScrollIntoViewAlignment
            /* 0x8292 */ "ScrollMode", // Windows.UI.Xaml.Controls.ScrollMode
            /* 0x8293 */ "SelectionMode", // Windows.UI.Xaml.Controls.SelectionMode
            /* 0x8294 */ "SliderSnapsTo", // Windows.UI.Xaml.Controls.Primitives.SliderSnapsTo
            /* 0x8295 */ "SnapPointsAlignment", // Windows.UI.Xaml.Controls.Primitives.SnapPointsAlignment
            /* 0x8296 */ "SnapPointsType", // Windows.UI.Xaml.Controls.SnapPointsType
            /* 0x8297 */ "Stereo3DVideoPackingMode", // Windows.UI.Xaml.Media.Stereo3DVideoPackingMode
            /* 0x8298 */ "Stereo3DVideoRenderMode", // Windows.UI.Xaml.Media.Stereo3DVideoRenderMode
            /* 0x8299 */ "Stretch", // Windows.UI.Xaml.Media.Stretch
            /* 0x829A */ "StretchDirection", // Windows.UI.Xaml.Controls.StretchDirection
            /* 0x829B */ "StyleSimulations", // Windows.UI.Xaml.Media.StyleSimulations
            /* 0x829C */ "SupportedTextSelection", // Windows.UI.Xaml.Automation.SupportedTextSelection
            /* 0x829D */ "SweepDirection", // Windows.UI.Xaml.Media.SweepDirection
            /* 0x829E */ "Symbol", // Windows.UI.Xaml.Controls.Symbol
            /* 0x829F */ "SynchronizedInputType", // Windows.UI.Xaml.Automation.SynchronizedInputType
            /* 0x82A0 */ "TextAlignment", // Windows.UI.Xaml.TextAlignment
            /* 0x82A1 */ "TextFormattingMode", // Windows.UI.Xaml.Media.TextFormattingMode
            /* 0x82A2 */ "TextHintingMode", // Windows.UI.Xaml.Media.TextHintingMode
            /* 0x82A3 */ "TextLineBounds", // Windows.UI.Xaml.TextLineBounds
            /* 0x82A4 */ "TextReadingOrder", // Windows.UI.Xaml.TextReadingOrder
            /* 0x82A5 */ "TextRenderingMode", // Windows.UI.Xaml.Media.TextRenderingMode
            /* 0x82A6 */ "TextTrimming", // Windows.UI.Xaml.TextTrimming
            /* 0x82A7 */ "TextWrapping", // Windows.UI.Xaml.TextWrapping
            /* 0x82A8 */ "TickPlacement", // Windows.UI.Xaml.Controls.Primitives.TickPlacement
            /* 0x82A9 */ "ToggleState", // Windows.UI.Xaml.Automation.ToggleState
            /* 0x82AA */ "TypeKind", // Windows.UI.Xaml.Interop.TypeKind
            /* 0x82AB */ "UpdateSourceTrigger", // Windows.UI.Xaml.Data.UpdateSourceTrigger
            /* 0x82AC */ "VerticalAlignment", // Windows.UI.Xaml.VerticalAlignment
            /* 0x82AD */ "VirtualizationMode", // Windows.UI.Xaml.Controls.VirtualizationMode
            /* 0x82AE */ "VirtualKey", // Windows.System.VirtualKey
            /* 0x82AF */ "VirtualKeyModifiers", // Windows.System.VirtualKeyModifiers
            /* 0x82B0 */ "Visibility", // Windows.UI.Xaml.Visibility
            /* 0x82B1 */ "WindowInteractionState", // Windows.UI.Xaml.Automation.WindowInteractionState
            /* 0x82B2 */ "WindowVisualState", // Windows.UI.Xaml.Automation.WindowVisualState
            /* 0x82B3 */ "ZoomMode", // Windows.UI.Xaml.Controls.ZoomMode
            /* 0x82B4 */ "ZoomUnit", // Windows.UI.Xaml.Automation.ZoomUnit
            /* 0x82B5 */ null,
            /* 0x82B6 */ null,
            /* 0x82B7 */ null,
            /* 0x82B8 */ null,
            /* 0x82B9 */ null,
            /* 0x82BA */ null,
            /* 0x82BB */ null,
            /* 0x82BC */ null,
            /* 0x82BD */ "StoryboardCollection", // Windows.UI.Xaml.Internal.StoryboardCollection
            /* 0x82BE */ "PluggableLayoutPanel", // Windows.UI.Xaml.Controls.PluggableLayoutPanel
            /* 0x82BF */ "AutomationNavigationDirection", // Windows.UI.Xaml.Automation.Peers.AutomationNavigationDirection
            /* 0x82C0 */ null,
            /* 0x82C1 */ null,
            /* 0x82C2 */ "CalendarViewTemplateSettings", // Windows.UI.Xaml.Controls.Primitives.CalendarViewTemplateSettings
            /* 0x82C3 */ "CalendarView", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x82C4 */ "CalendarViewBaseItem", // Windows.UI.Xaml.Controls.Primitives.CalendarViewBaseItem
            /* 0x82C5 */ "CalendarViewDayItem", // Windows.UI.Xaml.Controls.CalendarViewDayItem
            /* 0x82C6 */ "CalendarViewItem", // Windows.UI.Xaml.Controls.Primitives.CalendarViewItem
            /* 0x82C7 */ "CalendarViewDisplayMode", // Windows.UI.Xaml.Controls.CalendarViewDisplayMode
            /* 0x82C8 */ "CalendarViewSelectionMode", // Windows.UI.Xaml.Controls.CalendarViewSelectionMode
            /* 0x82C9 */ "DayOfWeek", // Windows.Globalization.DayOfWeek
            /* 0x82CA */ "TileGrid", // Windows.UI.Xaml.Controls.TileGrid
            /* 0x82CB */ "TileGridNestedPanel", // Windows.UI.Xaml.Controls.TileGridNestedPanel
            /* 0x82CC */ "DataPackageOperation", // Windows.ApplicationModel.DataTransfer.DataPackageOperation
            /* 0x82CD */ null,
            /* 0x82CE */ null,
            /* 0x82CF */ null,
            /* 0x82D0 */ null,
            /* 0x82D1 */ null,
            /* 0x82D2 */ null,
            /* 0x82D3 */ "CalendarPanel", // Windows.UI.Xaml.Controls.Primitives.CalendarPanel
            /* 0x82D4 */ null,
            /* 0x82D5 */ null,
            /* 0x82D6 */ null,
            /* 0x82D7 */ "SplitViewTemplateSettings", // Windows.UI.Xaml.Controls.Primitives.SplitViewTemplateSettings
            /* 0x82D8 */ "SplitView", // Windows.UI.Xaml.Controls.SplitView
            /* 0x82D9 */ "SplitViewDisplayMode", // Windows.UI.Xaml.Controls.SplitViewDisplayMode
            /* 0x82DA */ "SplitViewPanePlacement", // Windows.UI.Xaml.Controls.SplitViewPanePlacement
            /* 0x82DB */ "Transform3D", // Windows.UI.Xaml.Media.Media3D.Transform3D
            /* 0x82DC */ "CompositeTransform3D", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x82DD */ "PerspectiveTransform3D", // Windows.UI.Xaml.Media.Media3D.PerspectiveTransform3D
            /* 0x82DE */ "AutomationActiveEnd", // Windows.UI.Xaml.Automation.AutomationActiveEnd
            /* 0x82DF */ "AutomationAnimationStyle", // Windows.UI.Xaml.Automation.AutomationAnimationStyle
            /* 0x82E0 */ "AutomationBulletStyle", // Windows.UI.Xaml.Automation.AutomationBulletStyle
            /* 0x82E1 */ "AutomationCaretBidiMode", // Windows.UI.Xaml.Automation.AutomationCaretBidiMode
            /* 0x82E2 */ "AutomationCaretPosition", // Windows.UI.Xaml.Automation.AutomationCaretPosition
            /* 0x82E3 */ "AutomationFlowDirections", // Windows.UI.Xaml.Automation.AutomationFlowDirections
            /* 0x82E4 */ "AutomationOutlineStyles", // Windows.UI.Xaml.Automation.AutomationOutlineStyles
            /* 0x82E5 */ "AutomationStyleId", // Windows.UI.Xaml.Automation.AutomationStyleId
            /* 0x82E6 */ "AutomationTextDecorationLineStyle", // Windows.UI.Xaml.Automation.AutomationTextDecorationLineStyle
            /* 0x82E7 */ "AutomationTextEditChangeType", // Windows.UI.Xaml.Automation.AutomationTextEditChangeType
            /* 0x82E8 */ "RelativePanel", // Windows.UI.Xaml.Controls.RelativePanel
            /* 0x82E9 */ null,
            /* 0x82EA */ "DeferredElement", // Windows.UI.Xaml.Internal.DeferredElement
            /* 0x82EB */ "HWCompInkCanvasNode", // Windows.UI.Xaml.Internal.HWCompInkCanvasNode
            /* 0x82EC */ "InkCanvas", // Windows.UI.Xaml.Controls.InkCanvas
            /* 0x82ED */ "MenuFlyoutSubItem", // Windows.UI.Xaml.Controls.MenuFlyoutSubItem
            /* 0x82EE */ "AutomationStructureChangeType", // Windows.UI.Xaml.Automation.Peers.AutomationStructureChangeType
            /* 0x82EF */ "PasswordRevealMode", // Windows.UI.Xaml.Controls.PasswordRevealMode
            /* 0x82F0 */ null,
            /* 0x82F1 */ "FailedMediaStreamKind", // Windows.Media.Playback.FailedMediaStreamKind
            /* 0x82F2 */ null,
            /* 0x82F3 */ "TargetPropertyPath", // Windows.UI.Xaml.TargetPropertyPath
            /* 0x82F4 */ null,
            /* 0x82F5 */ "AdaptiveTrigger", // Windows.UI.Xaml.AdaptiveTrigger
            /* 0x82F6 */ "StateTriggerCollection", // Windows.UI.Xaml.Internal.StateTriggerCollection
            /* 0x82F7 */ "HWWindowedPopupCompTreeNode", // Windows.UI.Xaml.Internal.HWWindowedPopupCompTreeNode
            /* 0x82F8 */ "ListViewItemPresenterCheckMode", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenterCheckMode
            /* 0x82F9 */ "SoftwareBitmapSource", // Windows.UI.Xaml.Media.Imaging.SoftwareBitmapSource
            /* 0x82FA */ null,
            /* 0x82FB */ null,
            /* 0x82FC */ "StateTriggerBase", // Windows.UI.Xaml.StateTriggerBase
            /* 0x82FD */ null,
            /* 0x82FE */ "MenuPopupThemeTransition", // Windows.UI.Xaml.Media.Animation.MenuPopupThemeTransition
            /* 0x82FF */ "StateTrigger", // Windows.UI.Xaml.StateTrigger
            /* 0x8300 */ "WebViewExecutionMode", // Windows.UI.Xaml.Controls.WebViewExecutionMode
            /* 0x8301 */ "WebViewSettings", // Windows.UI.Xaml.Controls.WebViewSettings
            /* 0x8302 */ "WebViewPermissionState", // Windows.UI.Xaml.Controls.WebViewPermissionState
            /* 0x8303 */ "WebViewPermissionType", // Windows.UI.Xaml.Controls.WebViewPermissionType
            /* 0x8304 */ "PickerFlyoutThemeTransition", // Windows.UI.Xaml.Media.Animation.PickerFlyoutThemeTransition
            /* 0x8305 */ "CandidateWindowAlignment", // Windows.UI.Xaml.Controls.CandidateWindowAlignment
            /* 0x8306 */ "CalendarDatePicker", // Windows.UI.Xaml.Controls.CalendarDatePicker
            /* 0x8307 */ "ContentDialogOpenCloseThemeTransition", // Windows.UI.Xaml.Media.Animation.ContentDialogOpenCloseThemeTransition
            /* 0x8308 */ "ElementCompositionPreview", // Windows.UI.Xaml.Hosting.ElementCompositionPreview
            /* 0x8309 */ "MediaTransportControlsHelper", // Windows.UI.Xaml.Controls.MediaTransportControlsHelper
            /* 0x830A */ "AutoSuggestBoxQuerySubmittedEventArgs", // Windows.UI.Xaml.Controls.AutoSuggestBoxQuerySubmittedEventArgs
            /* 0x830B */ "AppBarTemplateSettings", // Windows.UI.Xaml.Controls.Primitives.AppBarTemplateSettings
            /* 0x830C */ "CommandBarTemplateSettings", // Windows.UI.Xaml.Controls.Primitives.CommandBarTemplateSettings
            /* 0x830D */ "CommandBarOverflowPresenter", // Windows.UI.Xaml.Controls.CommandBarOverflowPresenter
            /* 0x830E */ "DrillInThemeAnimation", // Windows.UI.Xaml.Media.Animation.DrillInThemeAnimation
            /* 0x830F */ "DrillOutThemeAnimation", // Windows.UI.Xaml.Media.Animation.DrillOutThemeAnimation
            /* 0x8310 */ "CalendarViewAutomationPeer", // Windows.UI.Xaml.Automation.Peers.CalendarViewAutomationPeer
            /* 0x8311 */ "CalendarViewBaseItemAutomationPeer", // Windows.UI.Xaml.Automation.Peers.CalendarViewBaseItemAutomationPeer
            /* 0x8312 */ "CalendarViewDayItemAutomationPeer", // Windows.UI.Xaml.Automation.Peers.CalendarViewDayItemAutomationPeer
            /* 0x8313 */ "CalendarViewItemAutomationPeer", // Windows.UI.Xaml.Automation.Peers.CalendarViewItemAutomationPeer
            /* 0x8314 */ "XamlBindingHelper", // Windows.UI.Xaml.Markup.XamlBindingHelper
            /* 0x8315 */ "AutomationAnnotation", // Windows.UI.Xaml.Automation.AutomationAnnotation
            /* 0x8316 */ "AutomationPeerAnnotation", // Windows.UI.Xaml.Automation.Peers.AutomationPeerAnnotation
            /* 0x8317 */ null,
            /* 0x8318 */ null,
            /* 0x8319 */ "AutomationAnnotationCollection", // Windows.UI.Xaml.Automation.AutomationAnnotationCollection
            /* 0x831A */ "AutomationPeerAnnotationCollection", // Windows.UI.Xaml.Automation.Peers.AutomationPeerAnnotationCollection
            /* 0x831B */ "MenuFlyoutSubItemAutomationPeer", // Windows.UI.Xaml.Automation.Peers.MenuFlyoutSubItemAutomationPeer
            /* 0x831C */ "SplitViewPaneAutomationPeer", // Windows.UI.Xaml.Automation.Peers.SplitViewPaneAutomationPeer
            /* 0x831D */ "UnderlineStyle", // Windows.UI.Xaml.Documents.UnderlineStyle
            /* 0x831E */ "SplitViewLightDismissAutomationPeer", // Windows.UI.Xaml.Automation.Peers.SplitViewLightDismissAutomationPeer
            /* 0x831F */ "RichEditClipboardFormat", // Windows.UI.Xaml.Controls.RichEditClipboardFormat
            /* 0x8320 */ null,
            /* 0x8321 */ "MenuFlyoutPresenterTemplateSettings", // Windows.UI.Xaml.Controls.Primitives.MenuFlyoutPresenterTemplateSettings
            /* 0x8322 */ null,
            /* 0x8323 */ "LandmarkTargetAutomationPeer", // Windows.UI.Xaml.Automation.Peers.LandmarkTargetAutomationPeer
            /* 0x8324 */ "AutomationLandmarkType", // Windows.UI.Xaml.Automation.Peers.AutomationLandmarkType
            /* 0x8325 */ "CalendarScrollViewerAutomationPeer", // Windows.UI.Xaml.Automation.Peers.CalendarScrollViewerAutomationPeer
            /* 0x8326 */ "CalendarDatePickerAutomationPeer", // Windows.UI.Xaml.Automation.Peers.CalendarDatePickerAutomationPeer
            /* 0x8327 */ null,
            /* 0x8328 */ null,
            /* 0x8329 */ null,
            /* 0x832A */ "CommandBarLabelPosition", // Windows.UI.Xaml.Controls.CommandBarLabelPosition
            /* 0x832B */ null,
            /* 0x832C */ "CommandBarDefaultLabelPosition", // Windows.UI.Xaml.Controls.CommandBarDefaultLabelPosition
            /* 0x832D */ null,
            /* 0x832E */ "CommandBarOverflowButtonVisibility", // Windows.UI.Xaml.Controls.CommandBarOverflowButtonVisibility
            /* 0x832F */ "HWRedirectedCompTreeNodeDComp", // Windows.UI.Xaml.Internal.HWRedirectedCompTreeNodeDComp
            /* 0x8330 */ "HWRedirectedCompTreeNodeWinRT", // Windows.UI.Xaml.Internal.HWRedirectedCompTreeNodeWinRT
            /* 0x8331 */ "HWWindowedPopupCompTreeNodeDComp", // Windows.UI.Xaml.Internal.HWWindowedPopupCompTreeNodeDComp
            /* 0x8332 */ "HWWindowedPopupCompTreeNodeWinRT", // Windows.UI.Xaml.Internal.HWWindowedPopupCompTreeNodeWinRT
            /* 0x8333 */ "CommandBarDynamicOverflowAction", // Windows.UI.Xaml.Controls.CommandBarDynamicOverflowAction
            /* 0x8334 */ "ConnectedAnimation", // Windows.UI.Xaml.Media.Animation.ConnectedAnimation
            /* 0x8335 */ "ConnectedAnimationService", // Windows.UI.Xaml.Media.Animation.ConnectedAnimationService
            /* 0x8336 */ "LightDismissOverlayMode", // Windows.UI.Xaml.Controls.LightDismissOverlayMode
            /* 0x8337 */ "FocusVisualKind", // Windows.UI.Xaml.FocusVisualKind
            /* 0x8338 */ "RequiresPointer", // Windows.UI.Xaml.Controls.RequiresPointer
            /* 0x8339 */ "ConnectedAnimationRoot", // Windows.UI.Xaml.ConnectedAnimationRoot
            /* 0x833A */ "MediaPlayer", // Windows.Media.Playback.MediaPlayer
            /* 0x833B */ "MediaPlayerElementAutomationPeer", // Windows.UI.Xaml.Automation.Peers.MediaPlayerElementAutomationPeer
            /* 0x833C */ "MediaPlayerPresenter", // Windows.UI.Xaml.Controls.MediaPlayerPresenter
            /* 0x833D */ "MediaPlayerElement", // Windows.UI.Xaml.Controls.MediaPlayerElement
            /* 0x833E */ "FastPlayFallbackBehaviour", // Windows.UI.Xaml.Media.FastPlayFallbackBehaviour
            /* 0x833F */ "ElementSoundKind", // Windows.UI.Xaml.ElementSoundKind
            /* 0x8340 */ "ElementSoundMode", // Windows.UI.Xaml.ElementSoundMode
            /* 0x8341 */ "ElementSoundPlayerState", // Windows.UI.Xaml.ElementSoundPlayerState
            /* 0x8342 */ "FullWindowMediaRootAutomationPeer", // Windows.UI.Xaml.FullWindowMediaRootAutomationPeer
            /* 0x8343 */ "ApplicationRequiresPointerMode", // Windows.UI.Xaml.ApplicationRequiresPointerMode
            /* 0x8344 */ "MediaPlaybackItemConverter", // Windows.UI.Xaml.Internal.MediaPlaybackItemConverter
            /* 0x8345 */ null,
            /* 0x8346 */ "BrushCollection", // Windows.UI.Xaml.Media.BrushCollection
            /* 0x8347 */ "CalendarViewHeaderAutomationPeer", // Windows.UI.Xaml.Automation.Peers.CalendarViewHeaderAutomationPeer
        };

        private static readonly string[] propertyNames = {
            /* 0x8001 */ "Index", // Windows.UI.Xaml.Controls.Primitives.GeneratorPosition
            /* 0x8002 */ "Offset", // Windows.UI.Xaml.Controls.Primitives.GeneratorPosition
            /* 0x8003 */ "Kind", // Windows.UI.Xaml.Interop.TypeName
            /* 0x8004 */ "Name", // Windows.UI.Xaml.Interop.TypeName
            /* 0x8005 */ "AcceleratorKey", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x8006 */ "AccessibilityView", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x8007 */ "AccessKey", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x8008 */ "AutomationId", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x8009 */ "ControlledPeers", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x800A */ "HelpText", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x800B */ "IsRequiredForForm", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x800C */ "ItemStatus", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x800D */ "ItemType", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x800E */ "LabeledBy", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x800F */ "LiveSetting", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x8010 */ "Name", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x8011 */ "Name", // Windows.UI.Xaml.DependencyObject
            /* 0x8012 */ "DeferredUnlinkingPayload", // Windows.UI.Xaml.Controls.ItemContainerGenerator
            /* 0x8013 */ "IsRecycledContainer", // Windows.UI.Xaml.Controls.ItemContainerGenerator
            /* 0x8014 */ "ItemForItemContainer", // Windows.UI.Xaml.Controls.ItemContainerGenerator
            /* 0x8015 */ "TextFormattingMode", // Windows.UI.Xaml.TextOptions
            /* 0x8016 */ "TextHintingMode", // Windows.UI.Xaml.TextOptions
            /* 0x8017 */ "TextRenderingMode", // Windows.UI.Xaml.TextOptions
            /* 0x8018 */ "Placement", // Windows.UI.Xaml.Controls.ToolTipService
            /* 0x8019 */ "PlacementTarget", // Windows.UI.Xaml.Controls.ToolTipService
            /* 0x801A */ "ToolTip", // Windows.UI.Xaml.Controls.ToolTipService
            /* 0x801B */ "ToolTipObject", // Windows.UI.Xaml.Controls.ToolTipService
            /* 0x801C */ "AnnotationAlternates", // Windows.UI.Xaml.Documents.Typography
            /* 0x801D */ "Capitals", // Windows.UI.Xaml.Documents.Typography
            /* 0x801E */ "CapitalSpacing", // Windows.UI.Xaml.Documents.Typography
            /* 0x801F */ "CaseSensitiveForms", // Windows.UI.Xaml.Documents.Typography
            /* 0x8020 */ "ContextualAlternates", // Windows.UI.Xaml.Documents.Typography
            /* 0x8021 */ "ContextualLigatures", // Windows.UI.Xaml.Documents.Typography
            /* 0x8022 */ "ContextualSwashes", // Windows.UI.Xaml.Documents.Typography
            /* 0x8023 */ "DiscretionaryLigatures", // Windows.UI.Xaml.Documents.Typography
            /* 0x8024 */ "EastAsianExpertForms", // Windows.UI.Xaml.Documents.Typography
            /* 0x8025 */ "EastAsianLanguage", // Windows.UI.Xaml.Documents.Typography
            /* 0x8026 */ "EastAsianWidths", // Windows.UI.Xaml.Documents.Typography
            /* 0x8027 */ "Fraction", // Windows.UI.Xaml.Documents.Typography
            /* 0x8028 */ "HistoricalForms", // Windows.UI.Xaml.Documents.Typography
            /* 0x8029 */ "HistoricalLigatures", // Windows.UI.Xaml.Documents.Typography
            /* 0x802A */ "Kerning", // Windows.UI.Xaml.Documents.Typography
            /* 0x802B */ "MathematicalGreek", // Windows.UI.Xaml.Documents.Typography
            /* 0x802C */ "NumeralAlignment", // Windows.UI.Xaml.Documents.Typography
            /* 0x802D */ "NumeralStyle", // Windows.UI.Xaml.Documents.Typography
            /* 0x802E */ "SlashedZero", // Windows.UI.Xaml.Documents.Typography
            /* 0x802F */ "StandardLigatures", // Windows.UI.Xaml.Documents.Typography
            /* 0x8030 */ "StandardSwashes", // Windows.UI.Xaml.Documents.Typography
            /* 0x8031 */ "StylisticAlternates", // Windows.UI.Xaml.Documents.Typography
            /* 0x8032 */ "StylisticSet1", // Windows.UI.Xaml.Documents.Typography
            /* 0x8033 */ "StylisticSet10", // Windows.UI.Xaml.Documents.Typography
            /* 0x8034 */ "StylisticSet11", // Windows.UI.Xaml.Documents.Typography
            /* 0x8035 */ "StylisticSet12", // Windows.UI.Xaml.Documents.Typography
            /* 0x8036 */ "StylisticSet13", // Windows.UI.Xaml.Documents.Typography
            /* 0x8037 */ "StylisticSet14", // Windows.UI.Xaml.Documents.Typography
            /* 0x8038 */ "StylisticSet15", // Windows.UI.Xaml.Documents.Typography
            /* 0x8039 */ "StylisticSet16", // Windows.UI.Xaml.Documents.Typography
            /* 0x803A */ "StylisticSet17", // Windows.UI.Xaml.Documents.Typography
            /* 0x803B */ "StylisticSet18", // Windows.UI.Xaml.Documents.Typography
            /* 0x803C */ "StylisticSet19", // Windows.UI.Xaml.Documents.Typography
            /* 0x803D */ "StylisticSet2", // Windows.UI.Xaml.Documents.Typography
            /* 0x803E */ "StylisticSet20", // Windows.UI.Xaml.Documents.Typography
            /* 0x803F */ "StylisticSet3", // Windows.UI.Xaml.Documents.Typography
            /* 0x8040 */ "StylisticSet4", // Windows.UI.Xaml.Documents.Typography
            /* 0x8041 */ "StylisticSet5", // Windows.UI.Xaml.Documents.Typography
            /* 0x8042 */ "StylisticSet6", // Windows.UI.Xaml.Documents.Typography
            /* 0x8043 */ "StylisticSet7", // Windows.UI.Xaml.Documents.Typography
            /* 0x8044 */ "StylisticSet8", // Windows.UI.Xaml.Documents.Typography
            /* 0x8045 */ "StylisticSet9", // Windows.UI.Xaml.Documents.Typography
            /* 0x8046 */ "Variants", // Windows.UI.Xaml.Documents.Typography
            /* 0x8047 */ "ApplicationStarted", // Windows.UI.Xaml.Application
            /* 0x8048 */ "RequestedTheme", // Windows.UI.Xaml.Application
            /* 0x8049 */ "Resources", // Windows.UI.Xaml.Application
            /* 0x804A */ "RootVisual", // Windows.UI.Xaml.Application
            /* 0x804B */ "EventsSource", // Windows.UI.Xaml.Automation.Peers.AutomationPeer
            /* 0x804C */ "SelectedItem", // Windows.UI.Xaml.Controls.AutoSuggestBoxSuggestionChosenEventArgs
            /* 0x804D */ "Reason", // Windows.UI.Xaml.Controls.AutoSuggestBoxTextChangedEventArgs
            /* 0x804E */ "Opacity", // Windows.UI.Xaml.Media.Brush
            /* 0x804F */ "RelativeTransform", // Windows.UI.Xaml.Media.Brush
            /* 0x8050 */ "Transform", // Windows.UI.Xaml.Media.Brush
            /* 0x8051 */ "IsSourceGrouped", // Windows.UI.Xaml.Data.CollectionViewSource
            /* 0x8052 */ "ItemsPath", // Windows.UI.Xaml.Data.CollectionViewSource
            /* 0x8053 */ "Source", // Windows.UI.Xaml.Data.CollectionViewSource
            /* 0x8054 */ "View", // Windows.UI.Xaml.Data.CollectionViewSource
            /* 0x8055 */ "A", // Windows.UI.Color
            /* 0x8056 */ "B", // Windows.UI.Color
            /* 0x8057 */ "ContentProperty", // Windows.UI.Color
            /* 0x8058 */ "G", // Windows.UI.Color
            /* 0x8059 */ "R", // Windows.UI.Color
            /* 0x805A */ "KeyTime", // Windows.UI.Xaml.Media.Animation.ColorKeyFrame
            /* 0x805B */ "Value", // Windows.UI.Xaml.Media.Animation.ColorKeyFrame
            /* 0x805C */ "ActualWidth", // Windows.UI.Xaml.Controls.ColumnDefinition
            /* 0x805D */ "MaxWidth", // Windows.UI.Xaml.Controls.ColumnDefinition
            /* 0x805E */ "MinWidth", // Windows.UI.Xaml.Controls.ColumnDefinition
            /* 0x805F */ "Width", // Windows.UI.Xaml.Controls.ColumnDefinition
            /* 0x8060 */ "DropDownClosedHeight", // Windows.UI.Xaml.Controls.Primitives.ComboBoxTemplateSettings
            /* 0x8061 */ "DropDownOffset", // Windows.UI.Xaml.Controls.Primitives.ComboBoxTemplateSettings
            /* 0x8062 */ "DropDownOpenedHeight", // Windows.UI.Xaml.Controls.Primitives.ComboBoxTemplateSettings
            /* 0x8063 */ "SelectedItemDirection", // Windows.UI.Xaml.Controls.Primitives.ComboBoxTemplateSettings
            /* 0x8064 */ "BottomLeft", // Windows.UI.Xaml.CornerRadius
            /* 0x8065 */ "BottomRight", // Windows.UI.Xaml.CornerRadius
            /* 0x8066 */ "TopLeft", // Windows.UI.Xaml.CornerRadius
            /* 0x8067 */ "TopRight", // Windows.UI.Xaml.CornerRadius
            /* 0x8068 */ null,
            /* 0x8069 */ "PropertyId", // Windows.UI.Xaml.DependencyProperty
            /* 0x806A */ "ContentProperty", // Windows.Foundation.Double
            /* 0x806B */ "KeyTime", // Windows.UI.Xaml.Media.Animation.DoubleKeyFrame
            /* 0x806C */ "Value", // Windows.UI.Xaml.Media.Animation.DoubleKeyFrame
            /* 0x806D */ null,
            /* 0x806E */ null,
            /* 0x806F */ "EasingMode", // Windows.UI.Xaml.Media.Animation.EasingFunctionBase
            /* 0x8070 */ "MarkupExtensionType", // Windows.UI.Xaml.Internal.ExternalObjectReference
            /* 0x8071 */ "NativeValue", // Windows.UI.Xaml.Internal.ExternalObjectReference
            /* 0x8072 */ "AttachedFlyout", // Windows.UI.Xaml.Controls.Primitives.FlyoutBase
            /* 0x8073 */ "Placement", // Windows.UI.Xaml.Controls.Primitives.FlyoutBase
            /* 0x8074 */ "Weight", // Windows.UI.Text.FontWeight
            /* 0x8075 */ "Template", // Windows.UI.Xaml.FrameworkTemplate
            /* 0x8076 */ "Bounds", // Windows.UI.Xaml.Media.Geometry
            /* 0x8077 */ "Transform", // Windows.UI.Xaml.Media.Geometry
            /* 0x8078 */ "Color", // Windows.UI.Xaml.Media.GradientStop
            /* 0x8079 */ "Offset", // Windows.UI.Xaml.Media.GradientStop
            /* 0x807A */ "GridUnitType", // Windows.UI.Xaml.GridLength
            /* 0x807B */ "Value", // Windows.UI.Xaml.GridLength
            /* 0x807C */ "ContainerStyle", // Windows.UI.Xaml.Controls.GroupStyle
            /* 0x807D */ "ContainerStyleSelector", // Windows.UI.Xaml.Controls.GroupStyle
            /* 0x807E */ "HeaderContainerStyle", // Windows.UI.Xaml.Controls.GroupStyle
            /* 0x807F */ "HeaderTemplate", // Windows.UI.Xaml.Controls.GroupStyle
            /* 0x8080 */ "HeaderTemplateSelector", // Windows.UI.Xaml.Controls.GroupStyle
            /* 0x8081 */ "HidesIfEmpty", // Windows.UI.Xaml.Controls.GroupStyle
            /* 0x8082 */ "Panel", // Windows.UI.Xaml.Controls.GroupStyle
            /* 0x8083 */ "CandidateFontSize", // Windows.UI.Xaml.Controls.IMECandidateItem
            /* 0x8084 */ "CandidateIndex", // Windows.UI.Xaml.Controls.IMECandidateItem
            /* 0x8085 */ "CandidateMargin", // Windows.UI.Xaml.Controls.IMECandidateItem
            /* 0x8086 */ "CandidateString", // Windows.UI.Xaml.Controls.IMECandidateItem
            /* 0x8087 */ "KeyboardShortcut", // Windows.UI.Xaml.Controls.IMECandidateItem
            /* 0x8088 */ "Metadata", // Windows.UI.Xaml.Controls.IMECandidateItem
            /* 0x8089 */ "MetadataVisibility", // Windows.UI.Xaml.Controls.IMECandidateItem
            /* 0x808A */ "SecondaryFontSize", // Windows.UI.Xaml.Controls.IMECandidateItem
            /* 0x808B */ "ShortcutOpacity", // Windows.UI.Xaml.Controls.IMECandidateItem
            /* 0x808C */ "ShortcutVisibility", // Windows.UI.Xaml.Controls.IMECandidateItem
            /* 0x808D */ "Items", // Windows.UI.Xaml.Controls.IMECandidatePage
            /* 0x808E */ "PageIndex", // Windows.UI.Xaml.Controls.IMECandidatePage
            /* 0x808F */ "Width", // Windows.UI.Xaml.Controls.IMECandidatePage
            /* 0x8090 */ "DesiredDeceleration", // Windows.UI.Xaml.Input.InertiaExpansionBehavior
            /* 0x8091 */ "DesiredExpansion", // Windows.UI.Xaml.Input.InertiaExpansionBehavior
            /* 0x8092 */ "DesiredDeceleration", // Windows.UI.Xaml.Input.InertiaRotationBehavior
            /* 0x8093 */ "DesiredRotation", // Windows.UI.Xaml.Input.InertiaRotationBehavior
            /* 0x8094 */ "DesiredDeceleration", // Windows.UI.Xaml.Input.InertiaTranslationBehavior
            /* 0x8095 */ "DesiredDisplacement", // Windows.UI.Xaml.Input.InertiaTranslationBehavior
            /* 0x8096 */ "Names", // Windows.UI.Xaml.Input.InputScope
            /* 0x8097 */ "NameValue", // Windows.UI.Xaml.Input.InputScopeName
            /* 0x8098 */ "ContentProperty", // Windows.Foundation.Int32
            /* 0x8099 */ "ControlPoint1", // Windows.UI.Xaml.Media.Animation.KeySpline
            /* 0x809A */ "ControlPoint2", // Windows.UI.Xaml.Media.Animation.KeySpline
            /* 0x809B */ "Bounds", // Windows.UI.Xaml.LayoutTransitionStaggerItem
            /* 0x809C */ "Element", // Windows.UI.Xaml.LayoutTransitionStaggerItem
            /* 0x809D */ "Index", // Windows.UI.Xaml.LayoutTransitionStaggerItem
            /* 0x809E */ "StaggerTime", // Windows.UI.Xaml.LayoutTransitionStaggerItem
            /* 0x809F */ "Center", // Windows.UI.Xaml.Input.ManipulationPivot
            /* 0x80A0 */ "Radius", // Windows.UI.Xaml.Input.ManipulationPivot
            /* 0x80A1 */ "M11", // Windows.UI.Xaml.Media.Matrix
            /* 0x80A2 */ "M12", // Windows.UI.Xaml.Media.Matrix
            /* 0x80A3 */ "M21", // Windows.UI.Xaml.Media.Matrix
            /* 0x80A4 */ "M22", // Windows.UI.Xaml.Media.Matrix
            /* 0x80A5 */ "OffsetX", // Windows.UI.Xaml.Media.Matrix
            /* 0x80A6 */ "OffsetY", // Windows.UI.Xaml.Media.Matrix
            /* 0x80A7 */ "M11", // Windows.UI.Xaml.Media.Media3D.Matrix3D
            /* 0x80A8 */ "M12", // Windows.UI.Xaml.Media.Media3D.Matrix3D
            /* 0x80A9 */ "M13", // Windows.UI.Xaml.Media.Media3D.Matrix3D
            /* 0x80AA */ "M14", // Windows.UI.Xaml.Media.Media3D.Matrix3D
            /* 0x80AB */ "M21", // Windows.UI.Xaml.Media.Media3D.Matrix3D
            /* 0x80AC */ "M22", // Windows.UI.Xaml.Media.Media3D.Matrix3D
            /* 0x80AD */ "M23", // Windows.UI.Xaml.Media.Media3D.Matrix3D
            /* 0x80AE */ "M24", // Windows.UI.Xaml.Media.Media3D.Matrix3D
            /* 0x80AF */ "M31", // Windows.UI.Xaml.Media.Media3D.Matrix3D
            /* 0x80B0 */ "M32", // Windows.UI.Xaml.Media.Media3D.Matrix3D
            /* 0x80B1 */ "M33", // Windows.UI.Xaml.Media.Media3D.Matrix3D
            /* 0x80B2 */ "M34", // Windows.UI.Xaml.Media.Media3D.Matrix3D
            /* 0x80B3 */ "M44", // Windows.UI.Xaml.Media.Media3D.Matrix3D
            /* 0x80B4 */ "OffsetX", // Windows.UI.Xaml.Media.Media3D.Matrix3D
            /* 0x80B5 */ "OffsetY", // Windows.UI.Xaml.Media.Media3D.Matrix3D
            /* 0x80B6 */ "OffsetZ", // Windows.UI.Xaml.Media.Media3D.Matrix3D
            /* 0x80B7 */ "KeyTime", // Windows.UI.Xaml.Media.Animation.ObjectKeyFrame
            /* 0x80B8 */ "Value", // Windows.UI.Xaml.Media.Animation.ObjectKeyFrame
            /* 0x80B9 */ "SourcePageType", // Windows.UI.Xaml.Navigation.PageStackEntry
            /* 0x80BA */ "CurveSegments", // Windows.UI.Xaml.Internal.ParametricCurve
            /* 0x80BB */ "BeginOffset", // Windows.UI.Xaml.Internal.ParametricCurveSegment
            /* 0x80BC */ "ConstantCoefficient", // Windows.UI.Xaml.Internal.ParametricCurveSegment
            /* 0x80BD */ "CubicCoefficient", // Windows.UI.Xaml.Internal.ParametricCurveSegment
            /* 0x80BE */ "LinearCoefficient", // Windows.UI.Xaml.Internal.ParametricCurveSegment
            /* 0x80BF */ "QuadraticCoefficient", // Windows.UI.Xaml.Internal.ParametricCurveSegment
            /* 0x80C0 */ "IsClosed", // Windows.UI.Xaml.Media.PathFigure
            /* 0x80C1 */ "IsFilled", // Windows.UI.Xaml.Media.PathFigure
            /* 0x80C2 */ "Segments", // Windows.UI.Xaml.Media.PathFigure
            /* 0x80C3 */ "StartPoint", // Windows.UI.Xaml.Media.PathFigure
            /* 0x80C4 */ "ContentProperty", // Windows.Foundation.Point
            /* 0x80C5 */ "X", // Windows.Foundation.Point
            /* 0x80C6 */ "Y", // Windows.Foundation.Point
            /* 0x80C7 */ "IsInContact", // Windows.UI.Xaml.Input.Pointer
            /* 0x80C8 */ "IsInRange", // Windows.UI.Xaml.Input.Pointer
            /* 0x80C9 */ "PointerDeviceType", // Windows.UI.Xaml.Input.Pointer
            /* 0x80CA */ "PointerId", // Windows.UI.Xaml.Input.Pointer
            /* 0x80CB */ "PointerValue", // Windows.UI.Xaml.Internal.PointerKeyFrame
            /* 0x80CC */ "TargetValue", // Windows.UI.Xaml.Internal.PointerKeyFrame
            /* 0x80CD */ "KeyTime", // Windows.UI.Xaml.Media.Animation.PointKeyFrame
            /* 0x80CE */ "Value", // Windows.UI.Xaml.Media.Animation.PointKeyFrame
            /* 0x80CF */ "Count", // Windows.UI.Xaml.Collections.PresentationFrameworkCollection
            /* 0x80D0 */ "DesiredFormat", // Windows.UI.Xaml.Printing.PrintDocument
            /* 0x80D1 */ "DocumentSource", // Windows.UI.Xaml.Printing.PrintDocument
            /* 0x80D2 */ "PrintedPageCount", // Windows.UI.Xaml.Printing.PrintDocument
            /* 0x80D3 */ "ContainerAnimationEndPosition", // Windows.UI.Xaml.Controls.Primitives.ProgressBarTemplateSettings
            /* 0x80D4 */ "ContainerAnimationStartPosition", // Windows.UI.Xaml.Controls.Primitives.ProgressBarTemplateSettings
            /* 0x80D5 */ "EllipseAnimationEndPosition", // Windows.UI.Xaml.Controls.Primitives.ProgressBarTemplateSettings
            /* 0x80D6 */ "EllipseAnimationWellPosition", // Windows.UI.Xaml.Controls.Primitives.ProgressBarTemplateSettings
            /* 0x80D7 */ "EllipseDiameter", // Windows.UI.Xaml.Controls.Primitives.ProgressBarTemplateSettings
            /* 0x80D8 */ "EllipseOffset", // Windows.UI.Xaml.Controls.Primitives.ProgressBarTemplateSettings
            /* 0x80D9 */ "IndicatorLengthDelta", // Windows.UI.Xaml.Controls.Primitives.ProgressBarTemplateSettings
            /* 0x80DA */ "EllipseDiameter", // Windows.UI.Xaml.Controls.Primitives.ProgressRingTemplateSettings
            /* 0x80DB */ "EllipseOffset", // Windows.UI.Xaml.Controls.Primitives.ProgressRingTemplateSettings
            /* 0x80DC */ "MaxSideLength", // Windows.UI.Xaml.Controls.Primitives.ProgressRingTemplateSettings
            /* 0x80DD */ "Path", // Windows.UI.Xaml.PropertyPath
            /* 0x80DE */ "Height", // Windows.Foundation.Rect
            /* 0x80DF */ "Width", // Windows.Foundation.Rect
            /* 0x80E0 */ "X", // Windows.Foundation.Rect
            /* 0x80E1 */ "Y", // Windows.Foundation.Rect
            /* 0x80E2 */ "ActualHeight", // Windows.UI.Xaml.Controls.RowDefinition
            /* 0x80E3 */ "Height", // Windows.UI.Xaml.Controls.RowDefinition
            /* 0x80E4 */ "MaxHeight", // Windows.UI.Xaml.Controls.RowDefinition
            /* 0x80E5 */ "MinHeight", // Windows.UI.Xaml.Controls.RowDefinition
            /* 0x80E6 */ "Curves", // Windows.UI.Xaml.Internal.SecondaryContentRelationship
            /* 0x80E7 */ "IsDescendant", // Windows.UI.Xaml.Internal.SecondaryContentRelationship
            /* 0x80E8 */ "ShouldTargetClip", // Windows.UI.Xaml.Internal.SecondaryContentRelationship
            /* 0x80E9 */ "IsSealed", // Windows.UI.Xaml.SetterBase
            /* 0x80EA */ "BorderBrush", // Windows.UI.Xaml.Controls.Primitives.SettingsFlyoutTemplateSettings
            /* 0x80EB */ "BorderThickness", // Windows.UI.Xaml.Controls.Primitives.SettingsFlyoutTemplateSettings
            /* 0x80EC */ "ContentTransitions", // Windows.UI.Xaml.Controls.Primitives.SettingsFlyoutTemplateSettings
            /* 0x80ED */ "HeaderBackground", // Windows.UI.Xaml.Controls.Primitives.SettingsFlyoutTemplateSettings
            /* 0x80EE */ "HeaderForeground", // Windows.UI.Xaml.Controls.Primitives.SettingsFlyoutTemplateSettings
            /* 0x80EF */ "IconSource", // Windows.UI.Xaml.Controls.Primitives.SettingsFlyoutTemplateSettings
            /* 0x80F0 */ "Height", // Windows.Foundation.Size
            /* 0x80F1 */ "Width", // Windows.Foundation.Size
            /* 0x80F2 */ "Color", // Windows.UI.Xaml.Internal.SolidColorBrushClone
            /* 0x80F3 */ "ContentProperty", // Windows.Foundation.String
            /* 0x80F4 */ "BasedOn", // Windows.UI.Xaml.Style
            /* 0x80F5 */ "IsSealed", // Windows.UI.Xaml.Style
            /* 0x80F6 */ "Setters", // Windows.UI.Xaml.Style
            /* 0x80F7 */ "TargetType", // Windows.UI.Xaml.Style
            /* 0x80F8 */ "Owner", // Windows.UI.Xaml.Automation.Peers.TextAdapter
            /* 0x80F9 */ "CharacterSpacing", // Windows.UI.Xaml.Documents.TextElement
            /* 0x80FA */ "FontFamily", // Windows.UI.Xaml.Documents.TextElement
            /* 0x80FB */ "FontSize", // Windows.UI.Xaml.Documents.TextElement
            /* 0x80FC */ "FontStretch", // Windows.UI.Xaml.Documents.TextElement
            /* 0x80FD */ "FontStyle", // Windows.UI.Xaml.Documents.TextElement
            /* 0x80FE */ "FontWeight", // Windows.UI.Xaml.Documents.TextElement
            /* 0x80FF */ "Foreground", // Windows.UI.Xaml.Documents.TextElement
            /* 0x8100 */ "IsTextScaleFactorEnabled", // Windows.UI.Xaml.Documents.TextElement
            /* 0x8101 */ "Language", // Windows.UI.Xaml.Documents.TextElement
            /* 0x8102 */ "Owner", // Windows.UI.Xaml.Automation.Peers.TextRangeAdapter
            /* 0x8103 */ "Bottom", // Windows.UI.Xaml.Thickness
            /* 0x8104 */ "Left", // Windows.UI.Xaml.Thickness
            /* 0x8105 */ "Right", // Windows.UI.Xaml.Thickness
            /* 0x8106 */ "Top", // Windows.UI.Xaml.Thickness
            /* 0x8107 */ "AutoReverse", // Windows.UI.Xaml.Media.Animation.Timeline
            /* 0x8108 */ "BeginTime", // Windows.UI.Xaml.Media.Animation.Timeline
            /* 0x8109 */ "Duration", // Windows.UI.Xaml.Media.Animation.Timeline
            /* 0x810A */ "FillBehavior", // Windows.UI.Xaml.Media.Animation.Timeline
            /* 0x810B */ "RepeatBehavior", // Windows.UI.Xaml.Media.Animation.Timeline
            /* 0x810C */ "SpeedRatio", // Windows.UI.Xaml.Media.Animation.Timeline
            /* 0x810D */ "Text", // Windows.UI.Xaml.Media.TimelineMarker
            /* 0x810E */ "Time", // Windows.UI.Xaml.Media.TimelineMarker
            /* 0x810F */ "Type", // Windows.UI.Xaml.Media.TimelineMarker
            /* 0x8110 */ "Seconds", // Windows.Foundation.TimeSpan
            /* 0x8111 */ "CurtainCurrentToOffOffset", // Windows.UI.Xaml.Controls.Primitives.ToggleSwitchTemplateSettings
            /* 0x8112 */ "CurtainCurrentToOnOffset", // Windows.UI.Xaml.Controls.Primitives.ToggleSwitchTemplateSettings
            /* 0x8113 */ "CurtainOffToOnOffset", // Windows.UI.Xaml.Controls.Primitives.ToggleSwitchTemplateSettings
            /* 0x8114 */ "CurtainOnToOffOffset", // Windows.UI.Xaml.Controls.Primitives.ToggleSwitchTemplateSettings
            /* 0x8115 */ "KnobCurrentToOffOffset", // Windows.UI.Xaml.Controls.Primitives.ToggleSwitchTemplateSettings
            /* 0x8116 */ "KnobCurrentToOnOffset", // Windows.UI.Xaml.Controls.Primitives.ToggleSwitchTemplateSettings
            /* 0x8117 */ "KnobOffToOnOffset", // Windows.UI.Xaml.Controls.Primitives.ToggleSwitchTemplateSettings
            /* 0x8118 */ "KnobOnToOffOffset", // Windows.UI.Xaml.Controls.Primitives.ToggleSwitchTemplateSettings
            /* 0x8119 */ "FromHorizontalOffset", // Windows.UI.Xaml.Controls.Primitives.ToolTipTemplateSettings
            /* 0x811A */ "FromVerticalOffset", // Windows.UI.Xaml.Controls.Primitives.ToolTipTemplateSettings
            /* 0x811B */ "GeneratedStaggerFunction", // Windows.UI.Xaml.Media.Animation.Transition
            /* 0x811C */ "ClipTransform", // Windows.UI.Xaml.Media.Animation.TransitionTarget
            /* 0x811D */ "ClipTransformOrigin", // Windows.UI.Xaml.Media.Animation.TransitionTarget
            /* 0x811E */ "CompositeTransform", // Windows.UI.Xaml.Media.Animation.TransitionTarget
            /* 0x811F */ "Opacity", // Windows.UI.Xaml.Media.Animation.TransitionTarget
            /* 0x8120 */ "Projection", // Windows.UI.Xaml.Media.Animation.TransitionTarget
            /* 0x8121 */ "TransformOrigin", // Windows.UI.Xaml.Media.Animation.TransitionTarget
            /* 0x8122 */ null,
            /* 0x8123 */ null,
            /* 0x8124 */ "AllowDrop", // Windows.UI.Xaml.UIElement
            /* 0x8125 */ "CacheMode", // Windows.UI.Xaml.UIElement
            /* 0x8126 */ "ChildrenInternal", // Windows.UI.Xaml.UIElement
            /* 0x8127 */ "Clip", // Windows.UI.Xaml.UIElement
            /* 0x8128 */ "CompositeMode", // Windows.UI.Xaml.UIElement
            /* 0x8129 */ "IsDoubleTapEnabled", // Windows.UI.Xaml.UIElement
            /* 0x812A */ "IsHitTestVisible", // Windows.UI.Xaml.UIElement
            /* 0x812B */ "IsHoldingEnabled", // Windows.UI.Xaml.UIElement
            /* 0x812C */ "IsRightTapEnabled", // Windows.UI.Xaml.UIElement
            /* 0x812D */ "IsTapEnabled", // Windows.UI.Xaml.UIElement
            /* 0x812E */ "ManipulationMode", // Windows.UI.Xaml.UIElement
            /* 0x812F */ "Opacity", // Windows.UI.Xaml.UIElement
            /* 0x8130 */ "PointerCaptures", // Windows.UI.Xaml.UIElement
            /* 0x8131 */ "Projection", // Windows.UI.Xaml.UIElement
            /* 0x8132 */ "RenderSize", // Windows.UI.Xaml.UIElement
            /* 0x8133 */ "RenderTransform", // Windows.UI.Xaml.UIElement
            /* 0x8134 */ "RenderTransformOrigin", // Windows.UI.Xaml.UIElement
            /* 0x8135 */ "Transitions", // Windows.UI.Xaml.UIElement
            /* 0x8136 */ "TransitionTarget", // Windows.UI.Xaml.UIElement
            /* 0x8137 */ "UseLayoutRounding", // Windows.UI.Xaml.UIElement
            /* 0x8138 */ "Visibility", // Windows.UI.Xaml.UIElement
            /* 0x8139 */ "Clip", // Windows.UI.Xaml.Internal.UIElementClone
            /* 0x813A */ "LayoutClip", // Windows.UI.Xaml.Internal.UIElementClone
            /* 0x813B */ "OffsetX", // Windows.UI.Xaml.Internal.UIElementClone
            /* 0x813C */ "OffsetY", // Windows.UI.Xaml.Internal.UIElementClone
            /* 0x813D */ "Opacity", // Windows.UI.Xaml.Internal.UIElementClone
            /* 0x813E */ "Projection", // Windows.UI.Xaml.Internal.UIElementClone
            /* 0x813F */ "Transform", // Windows.UI.Xaml.Internal.UIElementClone
            /* 0x8140 */ "TransitionTarget", // Windows.UI.Xaml.Internal.UIElementClone
            /* 0x8141 */ "__DeferredStoryboard", // Windows.UI.Xaml.VisualState
            /* 0x8142 */ "Storyboard", // Windows.UI.Xaml.VisualState
            /* 0x8143 */ "States", // Windows.UI.Xaml.VisualStateGroup
            /* 0x8144 */ "Transitions", // Windows.UI.Xaml.VisualStateGroup
            /* 0x8145 */ "CustomVisualStateManager", // Windows.UI.Xaml.VisualStateManager
            /* 0x8146 */ "VisualStateGroups", // Windows.UI.Xaml.VisualStateManager
            /* 0x8147 */ "From", // Windows.UI.Xaml.VisualTransition
            /* 0x8148 */ "GeneratedDuration", // Windows.UI.Xaml.VisualTransition
            /* 0x8149 */ "GeneratedEasingFunction", // Windows.UI.Xaml.VisualTransition
            /* 0x814A */ "Storyboard", // Windows.UI.Xaml.VisualTransition
            /* 0x814B */ "To", // Windows.UI.Xaml.VisualTransition
            /* 0x814C */ "IsLargeArc", // Windows.UI.Xaml.Media.ArcSegment
            /* 0x814D */ "Point", // Windows.UI.Xaml.Media.ArcSegment
            /* 0x814E */ "RotationAngle", // Windows.UI.Xaml.Media.ArcSegment
            /* 0x814F */ "Size", // Windows.UI.Xaml.Media.ArcSegment
            /* 0x8150 */ "SweepDirection", // Windows.UI.Xaml.Media.ArcSegment
            /* 0x8151 */ "Amplitude", // Windows.UI.Xaml.Media.Animation.BackEase
            /* 0x8152 */ "Storyboard", // Windows.UI.Xaml.Media.Animation.BeginStoryboard
            /* 0x8153 */ "Point1", // Windows.UI.Xaml.Media.BezierSegment
            /* 0x8154 */ "Point2", // Windows.UI.Xaml.Media.BezierSegment
            /* 0x8155 */ "Point3", // Windows.UI.Xaml.Media.BezierSegment
            /* 0x8156 */ "PixelHeight", // Windows.UI.Xaml.Media.Imaging.BitmapSource
            /* 0x8157 */ "PixelWidth", // Windows.UI.Xaml.Media.Imaging.BitmapSource
            /* 0x8158 */ "LineHeight", // Windows.UI.Xaml.Documents.Block
            /* 0x8159 */ "LineStackingStrategy", // Windows.UI.Xaml.Documents.Block
            /* 0x815A */ "Margin", // Windows.UI.Xaml.Documents.Block
            /* 0x815B */ "TextAlignment", // Windows.UI.Xaml.Documents.Block
            /* 0x815C */ "Bounces", // Windows.UI.Xaml.Media.Animation.BounceEase
            /* 0x815D */ "Bounciness", // Windows.UI.Xaml.Media.Animation.BounceEase
            /* 0x815E */ "By", // Windows.UI.Xaml.Media.Animation.ColorAnimation
            /* 0x815F */ "EasingFunction", // Windows.UI.Xaml.Media.Animation.ColorAnimation
            /* 0x8160 */ "EnableDependentAnimation", // Windows.UI.Xaml.Media.Animation.ColorAnimation
            /* 0x8161 */ "From", // Windows.UI.Xaml.Media.Animation.ColorAnimation
            /* 0x8162 */ "To", // Windows.UI.Xaml.Media.Animation.ColorAnimation
            /* 0x8163 */ "EnableDependentAnimation", // Windows.UI.Xaml.Media.Animation.ColorAnimationUsingKeyFrames
            /* 0x8164 */ "KeyFrames", // Windows.UI.Xaml.Media.Animation.ColorAnimationUsingKeyFrames
            /* 0x8165 */ "HorizontalOffset", // Windows.UI.Xaml.Media.Animation.ContentThemeTransition
            /* 0x8166 */ "VerticalOffset", // Windows.UI.Xaml.Media.Animation.ContentThemeTransition
            /* 0x8167 */ "TargetType", // Windows.UI.Xaml.Controls.ControlTemplate
            /* 0x8168 */ "ResourceKey", // Windows.UI.Xaml.CustomResource
            /* 0x8169 */ "DataType", // Windows.UI.Xaml.DataTemplate
            /* 0x816A */ "Interval", // Windows.UI.Xaml.DispatcherTimer
            /* 0x816B */ "By", // Windows.UI.Xaml.Media.Animation.DoubleAnimation
            /* 0x816C */ "EasingFunction", // Windows.UI.Xaml.Media.Animation.DoubleAnimation
            /* 0x816D */ "EnableDependentAnimation", // Windows.UI.Xaml.Media.Animation.DoubleAnimation
            /* 0x816E */ "From", // Windows.UI.Xaml.Media.Animation.DoubleAnimation
            /* 0x816F */ "To", // Windows.UI.Xaml.Media.Animation.DoubleAnimation
            /* 0x8170 */ "EnableDependentAnimation", // Windows.UI.Xaml.Media.Animation.DoubleAnimationUsingKeyFrames
            /* 0x8171 */ "KeyFrames", // Windows.UI.Xaml.Media.Animation.DoubleAnimationUsingKeyFrames
            /* 0x8172 */ "TimeSpan", // Windows.UI.Xaml.Duration
            /* 0x8173 */ "Children", // Windows.UI.Xaml.Media.Animation.DynamicTimeline
            /* 0x8174 */ "EasingFunction", // Windows.UI.Xaml.Media.Animation.EasingColorKeyFrame
            /* 0x8175 */ "EasingFunction", // Windows.UI.Xaml.Media.Animation.EasingDoubleKeyFrame
            /* 0x8176 */ "EasingFunction", // Windows.UI.Xaml.Media.Animation.EasingPointKeyFrame
            /* 0x8177 */ "Edge", // Windows.UI.Xaml.Media.Animation.EdgeUIThemeTransition
            /* 0x8178 */ "Oscillations", // Windows.UI.Xaml.Media.Animation.ElasticEase
            /* 0x8179 */ "Springiness", // Windows.UI.Xaml.Media.Animation.ElasticEase
            /* 0x817A */ "Center", // Windows.UI.Xaml.Media.EllipseGeometry
            /* 0x817B */ "RadiusX", // Windows.UI.Xaml.Media.EllipseGeometry
            /* 0x817C */ "RadiusY", // Windows.UI.Xaml.Media.EllipseGeometry
            /* 0x817D */ "FromHorizontalOffset", // Windows.UI.Xaml.Media.Animation.EntranceThemeTransition
            /* 0x817E */ "FromVerticalOffset", // Windows.UI.Xaml.Media.Animation.EntranceThemeTransition
            /* 0x817F */ "IsStaggeringEnabled", // Windows.UI.Xaml.Media.Animation.EntranceThemeTransition
            /* 0x8180 */ "Actions", // Windows.UI.Xaml.EventTrigger
            /* 0x8181 */ "RoutedEvent", // Windows.UI.Xaml.EventTrigger
            /* 0x8182 */ "Exponent", // Windows.UI.Xaml.Media.Animation.ExponentialEase
            /* 0x8183 */ "Content", // Windows.UI.Xaml.Controls.Flyout
            /* 0x8184 */ "FlyoutPresenterStyle", // Windows.UI.Xaml.Controls.Flyout
            /* 0x8185 */ "ActualHeight", // Windows.UI.Xaml.FrameworkElement
            /* 0x8186 */ "ActualWidth", // Windows.UI.Xaml.FrameworkElement
            /* 0x8187 */ "DataContext", // Windows.UI.Xaml.FrameworkElement
            /* 0x8188 */ "FlowDirection", // Windows.UI.Xaml.FrameworkElement
            /* 0x8189 */ "Height", // Windows.UI.Xaml.FrameworkElement
            /* 0x818A */ "HorizontalAlignment", // Windows.UI.Xaml.FrameworkElement
            /* 0x818B */ "IsTextScaleFactorEnabledInternal", // Windows.UI.Xaml.FrameworkElement
            /* 0x818C */ "Language", // Windows.UI.Xaml.FrameworkElement
            /* 0x818D */ "Margin", // Windows.UI.Xaml.FrameworkElement
            /* 0x818E */ "MaxHeight", // Windows.UI.Xaml.FrameworkElement
            /* 0x818F */ "MaxWidth", // Windows.UI.Xaml.FrameworkElement
            /* 0x8190 */ "MinHeight", // Windows.UI.Xaml.FrameworkElement
            /* 0x8191 */ "MinWidth", // Windows.UI.Xaml.FrameworkElement
            /* 0x8192 */ "Parent", // Windows.UI.Xaml.FrameworkElement
            /* 0x8193 */ "RequestedTheme", // Windows.UI.Xaml.FrameworkElement
            /* 0x8194 */ "Resources", // Windows.UI.Xaml.FrameworkElement
            /* 0x8195 */ "Style", // Windows.UI.Xaml.FrameworkElement
            /* 0x8196 */ "Tag", // Windows.UI.Xaml.FrameworkElement
            /* 0x8197 */ "Triggers", // Windows.UI.Xaml.FrameworkElement
            /* 0x8198 */ "VerticalAlignment", // Windows.UI.Xaml.FrameworkElement
            /* 0x8199 */ "Width", // Windows.UI.Xaml.FrameworkElement
            /* 0x819A */ "Owner", // Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer
            /* 0x819B */ "Children", // Windows.UI.Xaml.Media.GeometryGroup
            /* 0x819C */ "FillRule", // Windows.UI.Xaml.Media.GeometryGroup
            /* 0x819D */ "ColorInterpolationMode", // Windows.UI.Xaml.Media.GradientBrush
            /* 0x819E */ "GradientStops", // Windows.UI.Xaml.Media.GradientBrush
            /* 0x819F */ "MappingMode", // Windows.UI.Xaml.Media.GradientBrush
            /* 0x81A0 */ "SpreadMethod", // Windows.UI.Xaml.Media.GradientBrush
            /* 0x81A1 */ "DragItemsCount", // Windows.UI.Xaml.Controls.Primitives.GridViewItemTemplateSettings
            /* 0x81A2 */ "TextDecorations", // Windows.UI.Xaml.Documents.Inline
            /* 0x81A3 */ "Item", // Windows.UI.Xaml.Automation.Peers.ItemAutomationPeer
            /* 0x81A4 */ "ItemsControlAutomationPeer", // Windows.UI.Xaml.Automation.Peers.ItemAutomationPeer
            /* 0x81A5 */ "TimeSpan", // Windows.UI.Xaml.Media.Animation.KeyTime
            /* 0x81A6 */ "EndPoint", // Windows.UI.Xaml.Media.LineGeometry
            /* 0x81A7 */ "StartPoint", // Windows.UI.Xaml.Media.LineGeometry
            /* 0x81A8 */ "Point", // Windows.UI.Xaml.Media.LineSegment
            /* 0x81A9 */ "DragItemsCount", // Windows.UI.Xaml.Controls.Primitives.ListViewItemTemplateSettings
            /* 0x81AA */ "ProjectionMatrix", // Windows.UI.Xaml.Media.Matrix3DProjection
            /* 0x81AB */ "Items", // Windows.UI.Xaml.Controls.MenuFlyout
            /* 0x81AC */ "MenuFlyoutPresenterStyle", // Windows.UI.Xaml.Controls.MenuFlyout
            /* 0x81AD */ "EnableDependentAnimation", // Windows.UI.Xaml.Media.Animation.ObjectAnimationUsingKeyFrames
            /* 0x81AE */ "KeyFrames", // Windows.UI.Xaml.Media.Animation.ObjectAnimationUsingKeyFrames
            /* 0x81AF */ "Edge", // Windows.UI.Xaml.Media.Animation.PaneThemeTransition
            /* 0x81B0 */ "Figures", // Windows.UI.Xaml.Media.PathGeometry
            /* 0x81B1 */ "FillRule", // Windows.UI.Xaml.Media.PathGeometry
            /* 0x81B2 */ "CenterOfRotationX", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x81B3 */ "CenterOfRotationY", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x81B4 */ "CenterOfRotationZ", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x81B5 */ "GlobalOffsetX", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x81B6 */ "GlobalOffsetY", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x81B7 */ "GlobalOffsetZ", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x81B8 */ "LocalOffsetX", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x81B9 */ "LocalOffsetY", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x81BA */ "LocalOffsetZ", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x81BB */ "ProjectionMatrix", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x81BC */ "RotationX", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x81BD */ "RotationY", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x81BE */ "RotationZ", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x81BF */ "By", // Windows.UI.Xaml.Media.Animation.PointAnimation
            /* 0x81C0 */ "EasingFunction", // Windows.UI.Xaml.Media.Animation.PointAnimation
            /* 0x81C1 */ "EnableDependentAnimation", // Windows.UI.Xaml.Media.Animation.PointAnimation
            /* 0x81C2 */ "From", // Windows.UI.Xaml.Media.Animation.PointAnimation
            /* 0x81C3 */ "To", // Windows.UI.Xaml.Media.Animation.PointAnimation
            /* 0x81C4 */ "EnableDependentAnimation", // Windows.UI.Xaml.Media.Animation.PointAnimationUsingKeyFrames
            /* 0x81C5 */ "KeyFrames", // Windows.UI.Xaml.Media.Animation.PointAnimationUsingKeyFrames
            /* 0x81C6 */ "KeyFrames", // Windows.UI.Xaml.Internal.PointerAnimationUsingKeyFrames
            /* 0x81C7 */ "PointerSource", // Windows.UI.Xaml.Internal.PointerAnimationUsingKeyFrames
            /* 0x81C8 */ "Points", // Windows.UI.Xaml.Media.PolyBezierSegment
            /* 0x81C9 */ "Points", // Windows.UI.Xaml.Media.PolyLineSegment
            /* 0x81CA */ "Points", // Windows.UI.Xaml.Media.PolyQuadraticBezierSegment
            /* 0x81CB */ "FromHorizontalOffset", // Windows.UI.Xaml.Media.Animation.PopupThemeTransition
            /* 0x81CC */ "FromVerticalOffset", // Windows.UI.Xaml.Media.Animation.PopupThemeTransition
            /* 0x81CD */ "Power", // Windows.UI.Xaml.Media.Animation.PowerEase
            /* 0x81CE */ "Delay", // Windows.UI.Xaml.PVLStaggerFunction
            /* 0x81CF */ "DelayReduce", // Windows.UI.Xaml.PVLStaggerFunction
            /* 0x81D0 */ "Maximum", // Windows.UI.Xaml.PVLStaggerFunction
            /* 0x81D1 */ "Reverse", // Windows.UI.Xaml.PVLStaggerFunction
            /* 0x81D2 */ "Point1", // Windows.UI.Xaml.Media.QuadraticBezierSegment
            /* 0x81D3 */ "Point2", // Windows.UI.Xaml.Media.QuadraticBezierSegment
            /* 0x81D4 */ "RadiusX", // Windows.UI.Xaml.Media.RectangleGeometry
            /* 0x81D5 */ "RadiusY", // Windows.UI.Xaml.Media.RectangleGeometry
            /* 0x81D6 */ "Rect", // Windows.UI.Xaml.Media.RectangleGeometry
            /* 0x81D7 */ "Mode", // Windows.UI.Xaml.Data.RelativeSource
            /* 0x81D8 */ "PixelHeight", // Windows.UI.Xaml.Media.Imaging.RenderTargetBitmap
            /* 0x81D9 */ "PixelWidth", // Windows.UI.Xaml.Media.Imaging.RenderTargetBitmap
            /* 0x81DA */ "Property", // Windows.UI.Xaml.Setter
            /* 0x81DB */ "Value", // Windows.UI.Xaml.Setter
            /* 0x81DC */ "Color", // Windows.UI.Xaml.Media.SolidColorBrush
            /* 0x81DD */ "KeySpline", // Windows.UI.Xaml.Media.Animation.SplineColorKeyFrame
            /* 0x81DE */ "KeySpline", // Windows.UI.Xaml.Media.Animation.SplineDoubleKeyFrame
            /* 0x81DF */ "KeySpline", // Windows.UI.Xaml.Media.Animation.SplinePointKeyFrame
            /* 0x81E0 */ "ResourceKey", // Windows.UI.Xaml.StaticResource
            /* 0x81E1 */ "Property", // Windows.UI.Xaml.Data.TemplateBinding
            /* 0x81E2 */ "ResourceKey", // Windows.UI.Xaml.ThemeResource
            /* 0x81E3 */ "AlignmentX", // Windows.UI.Xaml.Media.TileBrush
            /* 0x81E4 */ "AlignmentY", // Windows.UI.Xaml.Media.TileBrush
            /* 0x81E5 */ "Stretch", // Windows.UI.Xaml.Media.TileBrush
            /* 0x81E6 */ "ContentProperty", // Windows.UI.Xaml.Automation.Peers.AutomationPeerCollection
            /* 0x81E7 */ "Converter", // Windows.UI.Xaml.Data.Binding
            /* 0x81E8 */ "ConverterLanguage", // Windows.UI.Xaml.Data.Binding
            /* 0x81E9 */ "ConverterParameter", // Windows.UI.Xaml.Data.Binding
            /* 0x81EA */ "ElementName", // Windows.UI.Xaml.Data.Binding
            /* 0x81EB */ "FallbackValue", // Windows.UI.Xaml.Data.Binding
            /* 0x81EC */ "Mode", // Windows.UI.Xaml.Data.Binding
            /* 0x81ED */ "Path", // Windows.UI.Xaml.Data.Binding
            /* 0x81EE */ "RelativeSource", // Windows.UI.Xaml.Data.Binding
            /* 0x81EF */ "Source", // Windows.UI.Xaml.Data.Binding
            /* 0x81F0 */ "TargetNullValue", // Windows.UI.Xaml.Data.Binding
            /* 0x81F1 */ "UpdateSourceTrigger", // Windows.UI.Xaml.Data.Binding
            /* 0x81F2 */ "CreateOptions", // Windows.UI.Xaml.Media.Imaging.BitmapImage
            /* 0x81F3 */ "DecodePixelHeight", // Windows.UI.Xaml.Media.Imaging.BitmapImage
            /* 0x81F4 */ "DecodePixelType", // Windows.UI.Xaml.Media.Imaging.BitmapImage
            /* 0x81F5 */ "DecodePixelWidth", // Windows.UI.Xaml.Media.Imaging.BitmapImage
            /* 0x81F6 */ "UriSource", // Windows.UI.Xaml.Media.Imaging.BitmapImage
            /* 0x81F7 */ "Background", // Windows.UI.Xaml.Controls.Border
            /* 0x81F8 */ "BorderBrush", // Windows.UI.Xaml.Controls.Border
            /* 0x81F9 */ "BorderThickness", // Windows.UI.Xaml.Controls.Border
            /* 0x81FA */ "Child", // Windows.UI.Xaml.Controls.Border
            /* 0x81FB */ "ChildTransitions", // Windows.UI.Xaml.Controls.Border
            /* 0x81FC */ "CornerRadius", // Windows.UI.Xaml.Controls.Border
            /* 0x81FD */ "Padding", // Windows.UI.Xaml.Controls.Border
            /* 0x81FE */ "Source", // Windows.UI.Xaml.Controls.CaptureElement
            /* 0x81FF */ "Stretch", // Windows.UI.Xaml.Controls.CaptureElement
            /* 0x8200 */ "ContentProperty", // Windows.UI.Xaml.Media.Animation.ColorKeyFrameCollection
            /* 0x8201 */ "ContentProperty", // Windows.UI.Xaml.Controls.ColumnDefinitionCollection
            /* 0x8202 */ "CenterX", // Windows.UI.Xaml.Media.CompositeTransform
            /* 0x8203 */ "CenterY", // Windows.UI.Xaml.Media.CompositeTransform
            /* 0x8204 */ "Rotation", // Windows.UI.Xaml.Media.CompositeTransform
            /* 0x8205 */ "ScaleX", // Windows.UI.Xaml.Media.CompositeTransform
            /* 0x8206 */ "ScaleY", // Windows.UI.Xaml.Media.CompositeTransform
            /* 0x8207 */ "SkewX", // Windows.UI.Xaml.Media.CompositeTransform
            /* 0x8208 */ "SkewY", // Windows.UI.Xaml.Media.CompositeTransform
            /* 0x8209 */ "TranslateX", // Windows.UI.Xaml.Media.CompositeTransform
            /* 0x820A */ "TranslateY", // Windows.UI.Xaml.Media.CompositeTransform
            /* 0x820B */ "CharacterSpacing", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x820C */ "Content", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x820D */ "ContentTemplate", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x820E */ "ContentTemplateSelector", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x820F */ "ContentTransitions", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x8210 */ "FontFamily", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x8211 */ "FontSize", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x8212 */ "FontStretch", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x8213 */ "FontStyle", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x8214 */ "FontWeight", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x8215 */ "Foreground", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x8216 */ "IsTextScaleFactorEnabled", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x8217 */ "LineStackingStrategy", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x8218 */ "MaxLines", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x8219 */ "OpticalMarginAlignment", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x821A */ "SelectedContentTemplate", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x821B */ "TextLineBounds", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x821C */ "TextWrapping", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x821D */ "Background", // Windows.UI.Xaml.Controls.Control
            /* 0x821E */ "BorderBrush", // Windows.UI.Xaml.Controls.Control
            /* 0x821F */ "BorderThickness", // Windows.UI.Xaml.Controls.Control
            /* 0x8220 */ "CharacterSpacing", // Windows.UI.Xaml.Controls.Control
            /* 0x8221 */ "DefaultStyleKey", // Windows.UI.Xaml.Controls.Control
            /* 0x8222 */ "FocusState", // Windows.UI.Xaml.Controls.Control
            /* 0x8223 */ "FontFamily", // Windows.UI.Xaml.Controls.Control
            /* 0x8224 */ "FontSize", // Windows.UI.Xaml.Controls.Control
            /* 0x8225 */ "FontStretch", // Windows.UI.Xaml.Controls.Control
            /* 0x8226 */ "FontStyle", // Windows.UI.Xaml.Controls.Control
            /* 0x8227 */ "FontWeight", // Windows.UI.Xaml.Controls.Control
            /* 0x8228 */ "Foreground", // Windows.UI.Xaml.Controls.Control
            /* 0x8229 */ "HorizontalContentAlignment", // Windows.UI.Xaml.Controls.Control
            /* 0x822A */ "IsEnabled", // Windows.UI.Xaml.Controls.Control
            /* 0x822B */ "IsTabStop", // Windows.UI.Xaml.Controls.Control
            /* 0x822C */ "IsTextScaleFactorEnabled", // Windows.UI.Xaml.Controls.Control
            /* 0x822D */ "Padding", // Windows.UI.Xaml.Controls.Control
            /* 0x822E */ "TabIndex", // Windows.UI.Xaml.Controls.Control
            /* 0x822F */ "TabNavigation", // Windows.UI.Xaml.Controls.Control
            /* 0x8230 */ "Template", // Windows.UI.Xaml.Controls.Control
            /* 0x8231 */ "VerticalContentAlignment", // Windows.UI.Xaml.Controls.Control
            /* 0x8232 */ "DisplayMemberPath", // Windows.UI.Xaml.Internal.DisplayMemberTemplate
            /* 0x8233 */ "ContentProperty", // Windows.UI.Xaml.Media.DoubleCollection
            /* 0x8234 */ "ContentProperty", // Windows.UI.Xaml.Media.Animation.DoubleKeyFrameCollection
            /* 0x8235 */ "TargetName", // Windows.UI.Xaml.Media.Animation.DragItemThemeAnimation
            /* 0x8236 */ "Direction", // Windows.UI.Xaml.Media.Animation.DragOverThemeAnimation
            /* 0x8237 */ "TargetName", // Windows.UI.Xaml.Media.Animation.DragOverThemeAnimation
            /* 0x8238 */ "ToOffset", // Windows.UI.Xaml.Media.Animation.DragOverThemeAnimation
            /* 0x8239 */ "TargetName", // Windows.UI.Xaml.Media.Animation.DropTargetItemThemeAnimation
            /* 0x823A */ "TargetName", // Windows.UI.Xaml.Media.Animation.FadeInThemeAnimation
            /* 0x823B */ "TargetName", // Windows.UI.Xaml.Media.Animation.FadeOutThemeAnimation
            /* 0x823C */ "ContentProperty", // Windows.UI.Xaml.Media.FloatCollection
            /* 0x823D */ "ContentProperty", // Windows.UI.Xaml.Media.GeometryCollection
            /* 0x823E */ "Fill", // Windows.UI.Xaml.Documents.Glyphs
            /* 0x823F */ "FontRenderingEmSize", // Windows.UI.Xaml.Documents.Glyphs
            /* 0x8240 */ "FontUri", // Windows.UI.Xaml.Documents.Glyphs
            /* 0x8241 */ "Indices", // Windows.UI.Xaml.Documents.Glyphs
            /* 0x8242 */ "OriginX", // Windows.UI.Xaml.Documents.Glyphs
            /* 0x8243 */ "OriginY", // Windows.UI.Xaml.Documents.Glyphs
            /* 0x8244 */ "StyleSimulations", // Windows.UI.Xaml.Documents.Glyphs
            /* 0x8245 */ "UnicodeString", // Windows.UI.Xaml.Documents.Glyphs
            /* 0x8246 */ "ContentProperty", // Windows.UI.Xaml.Media.GradientStopCollection
            /* 0x8247 */ "ContentProperty", // Windows.UI.Xaml.Controls.HubSectionCollection
            /* 0x8248 */ "Foreground", // Windows.UI.Xaml.Controls.IconElement
            /* 0x8249 */ "DownloadProgress", // Windows.UI.Xaml.Controls.Image
            /* 0x824A */ "NineGrid", // Windows.UI.Xaml.Controls.Image
            /* 0x824B */ "PlayToSource", // Windows.UI.Xaml.Controls.Image
            /* 0x824C */ "Source", // Windows.UI.Xaml.Controls.Image
            /* 0x824D */ "Stretch", // Windows.UI.Xaml.Controls.Image
            /* 0x824E */ "DownloadProgress", // Windows.UI.Xaml.Media.ImageBrush
            /* 0x824F */ "ImageSource", // Windows.UI.Xaml.Media.ImageBrush
            /* 0x8250 */ "Child", // Windows.UI.Xaml.Documents.InlineUIContainer
            /* 0x8251 */ "ContentProperty", // Windows.UI.Xaml.Input.InputScopeNameCollection
            /* 0x8252 */ "Footer", // Windows.UI.Xaml.Controls.ItemsPresenter
            /* 0x8253 */ "FooterTemplate", // Windows.UI.Xaml.Controls.ItemsPresenter
            /* 0x8254 */ "FooterTransitions", // Windows.UI.Xaml.Controls.ItemsPresenter
            /* 0x8255 */ "Header", // Windows.UI.Xaml.Controls.ItemsPresenter
            /* 0x8256 */ "HeaderTemplate", // Windows.UI.Xaml.Controls.ItemsPresenter
            /* 0x8257 */ "HeaderTransitions", // Windows.UI.Xaml.Controls.ItemsPresenter
            /* 0x8258 */ "ItemsPanel", // Windows.UI.Xaml.Controls.ItemsPresenter
            /* 0x8259 */ "Padding", // Windows.UI.Xaml.Controls.ItemsPresenter
            /* 0x825A */ "EndPoint", // Windows.UI.Xaml.Media.LinearGradientBrush
            /* 0x825B */ "StartPoint", // Windows.UI.Xaml.Media.LinearGradientBrush
            /* 0x825C */ "Matrix", // Windows.UI.Xaml.Media.MatrixTransform
            /* 0x825D */ "ActualStereo3DVideoPackingMode", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x825E */ "AreTransportControlsEnabled", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x825F */ "AspectRatioHeight", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8260 */ "AspectRatioWidth", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8261 */ "AudioCategory", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8262 */ "AudioDeviceType", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8263 */ "AudioStreamCount", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8264 */ "AudioStreamIndex", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8265 */ "AutoPlay", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8266 */ "Balance", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8267 */ "BufferingProgress", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8268 */ "CanPause", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8269 */ "CanSeek", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x826A */ "CurrentState", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x826B */ "DefaultPlaybackRate", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x826C */ "DownloadProgress", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x826D */ "DownloadProgressOffset", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x826E */ "FullScreen", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x826F */ "IsAudioOnly", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8270 */ "IsFullWindow", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8271 */ "IsLooping", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8272 */ "IsMuted", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8273 */ "IsStereo3DVideo", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8274 */ "Markers", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8275 */ "NaturalDuration", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8276 */ "NaturalVideoHeight", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8277 */ "NaturalVideoWidth", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8278 */ "PlaybackRate", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8279 */ "PlayToPreferredSourceUri", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x827A */ "PlayToSource", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x827B */ "Position", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x827C */ "PosterSource", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x827D */ "ProtectionManager", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x827E */ "RealTimePlayback", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x827F */ "Source", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8280 */ "Stereo3DVideoPackingMode", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8281 */ "Stereo3DVideoRenderMode", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8282 */ "Stretch", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8283 */ "TransportControls", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8284 */ "Volume", // Windows.UI.Xaml.Controls.MediaElement
            /* 0x8285 */ "ContentProperty", // Windows.UI.Xaml.Controls.MenuFlyoutItemBaseCollection
            /* 0x8286 */ "ContentProperty", // Windows.UI.Xaml.Media.Animation.ObjectKeyFrameCollection
            /* 0x8287 */ "Background", // Windows.UI.Xaml.Controls.Panel
            /* 0x8288 */ "Children", // Windows.UI.Xaml.Controls.Panel
            /* 0x8289 */ "ChildrenTransitions", // Windows.UI.Xaml.Controls.Panel
            /* 0x828A */ "IsIgnoringTransitions", // Windows.UI.Xaml.Controls.Panel
            /* 0x828B */ "IsItemsHost", // Windows.UI.Xaml.Controls.Panel
            /* 0x828C */ "Inlines", // Windows.UI.Xaml.Documents.Paragraph
            /* 0x828D */ "TextIndent", // Windows.UI.Xaml.Documents.Paragraph
            /* 0x828E */ "ContentProperty", // Windows.UI.Xaml.Internal.ParametricCurveCollection
            /* 0x828F */ "ContentProperty", // Windows.UI.Xaml.Internal.ParametricCurveSegmentCollection
            /* 0x8290 */ "ContentProperty", // Windows.UI.Xaml.Media.PathFigureCollection
            /* 0x8291 */ "ContentProperty", // Windows.UI.Xaml.Media.PathSegmentCollection
            /* 0x8292 */ "ContentProperty", // Windows.UI.Xaml.Media.PointCollection
            /* 0x8293 */ "ContentProperty", // Windows.UI.Xaml.Input.PointerCollection
            /* 0x8294 */ "TargetName", // Windows.UI.Xaml.Media.Animation.PointerDownThemeAnimation
            /* 0x8295 */ "ContentProperty", // Windows.UI.Xaml.Internal.PointerKeyFrameCollection
            /* 0x8296 */ "TargetName", // Windows.UI.Xaml.Media.Animation.PointerUpThemeAnimation
            /* 0x8297 */ "ContentProperty", // Windows.UI.Xaml.Media.Animation.PointKeyFrameCollection
            /* 0x8298 */ "FromHorizontalOffset", // Windows.UI.Xaml.Media.Animation.PopInThemeAnimation
            /* 0x8299 */ "FromVerticalOffset", // Windows.UI.Xaml.Media.Animation.PopInThemeAnimation
            /* 0x829A */ "TargetName", // Windows.UI.Xaml.Media.Animation.PopInThemeAnimation
            /* 0x829B */ "TargetName", // Windows.UI.Xaml.Media.Animation.PopOutThemeAnimation
            /* 0x829C */ "Child", // Windows.UI.Xaml.Controls.Primitives.Popup
            /* 0x829D */ "ChildTransitions", // Windows.UI.Xaml.Controls.Primitives.Popup
            /* 0x829E */ "HorizontalOffset", // Windows.UI.Xaml.Controls.Primitives.Popup
            /* 0x829F */ "IsApplicationBarService", // Windows.UI.Xaml.Controls.Primitives.Popup
            /* 0x82A0 */ "IsFlyout", // Windows.UI.Xaml.Controls.Primitives.Popup
            /* 0x82A1 */ "IsLightDismissEnabled", // Windows.UI.Xaml.Controls.Primitives.Popup
            /* 0x82A2 */ "IsOpen", // Windows.UI.Xaml.Controls.Primitives.Popup
            /* 0x82A3 */ "IsSettingsFlyout", // Windows.UI.Xaml.Controls.Primitives.Popup
            /* 0x82A4 */ "VerticalOffset", // Windows.UI.Xaml.Controls.Primitives.Popup
            /* 0x82A5 */ "Center", // Windows.UI.Xaml.Media.RadialGradientBrush
            /* 0x82A6 */ "GradientOrigin", // Windows.UI.Xaml.Media.RadialGradientBrush
            /* 0x82A7 */ "RadiusX", // Windows.UI.Xaml.Media.RadialGradientBrush
            /* 0x82A8 */ "RadiusY", // Windows.UI.Xaml.Media.RadialGradientBrush
            /* 0x82A9 */ "Count", // Windows.UI.Xaml.Media.Animation.RepeatBehavior
            /* 0x82AA */ "Duration", // Windows.UI.Xaml.Media.Animation.RepeatBehavior
            /* 0x82AB */ "FromHorizontalOffset", // Windows.UI.Xaml.Media.Animation.RepositionThemeAnimation
            /* 0x82AC */ "FromVerticalOffset", // Windows.UI.Xaml.Media.Animation.RepositionThemeAnimation
            /* 0x82AD */ "TargetName", // Windows.UI.Xaml.Media.Animation.RepositionThemeAnimation
            /* 0x82AE */ "ContentProperty", // Windows.UI.Xaml.ResourceDictionary
            /* 0x82AF */ "MergedDictionaries", // Windows.UI.Xaml.ResourceDictionary
            /* 0x82B0 */ "Source", // Windows.UI.Xaml.ResourceDictionary
            /* 0x82B1 */ "ThemeDictionaries", // Windows.UI.Xaml.ResourceDictionary
            /* 0x82B2 */ "ContentProperty", // Windows.UI.Xaml.Internal.ResourceDictionaryCollection
            /* 0x82B3 */ "Blocks", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82B4 */ "CharacterSpacing", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82B5 */ "FontFamily", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82B6 */ "FontSize", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82B7 */ "FontStretch", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82B8 */ "FontStyle", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82B9 */ "FontWeight", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82BA */ "Foreground", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82BB */ "HasOverflowContent", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82BC */ "IsColorFontEnabled", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82BD */ "IsTextScaleFactorEnabled", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82BE */ "IsTextSelectionEnabled", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82BF */ "LineHeight", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82C0 */ "LineStackingStrategy", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82C1 */ "MaxLines", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82C2 */ "OpticalMarginAlignment", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82C3 */ "OverflowContentTarget", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82C4 */ "Padding", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82C5 */ "SelectedText", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82C6 */ "SelectionHighlightColor", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82C7 */ "TextAlignment", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82C8 */ "TextIndent", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82C9 */ "TextLineBounds", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82CA */ "TextReadingOrder", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82CB */ "TextTrimming", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82CC */ "TextWrapping", // Windows.UI.Xaml.Controls.RichTextBlock
            /* 0x82CD */ "HasOverflowContent", // Windows.UI.Xaml.Controls.RichTextBlockOverflow
            /* 0x82CE */ "MaxLines", // Windows.UI.Xaml.Controls.RichTextBlockOverflow
            /* 0x82CF */ "OverflowContentTarget", // Windows.UI.Xaml.Controls.RichTextBlockOverflow
            /* 0x82D0 */ "Padding", // Windows.UI.Xaml.Controls.RichTextBlockOverflow
            /* 0x82D1 */ "Angle", // Windows.UI.Xaml.Media.RotateTransform
            /* 0x82D2 */ "CenterX", // Windows.UI.Xaml.Media.RotateTransform
            /* 0x82D3 */ "CenterY", // Windows.UI.Xaml.Media.RotateTransform
            /* 0x82D4 */ "ContentProperty", // Windows.UI.Xaml.Controls.RowDefinitionCollection
            /* 0x82D5 */ "FlowDirection", // Windows.UI.Xaml.Documents.Run
            /* 0x82D6 */ "Text", // Windows.UI.Xaml.Documents.Run
            /* 0x82D7 */ "CenterX", // Windows.UI.Xaml.Media.ScaleTransform
            /* 0x82D8 */ "CenterY", // Windows.UI.Xaml.Media.ScaleTransform
            /* 0x82D9 */ "ScaleX", // Windows.UI.Xaml.Media.ScaleTransform
            /* 0x82DA */ "ScaleY", // Windows.UI.Xaml.Media.ScaleTransform
            /* 0x82DB */ "ContentProperty", // Windows.UI.Xaml.SetterBaseCollection
            /* 0x82DC */ "IsSealed", // Windows.UI.Xaml.SetterBaseCollection
            /* 0x82DD */ "Fill", // Windows.UI.Xaml.Shapes.Shape
            /* 0x82DE */ "GeometryTransform", // Windows.UI.Xaml.Shapes.Shape
            /* 0x82DF */ "Stretch", // Windows.UI.Xaml.Shapes.Shape
            /* 0x82E0 */ "Stroke", // Windows.UI.Xaml.Shapes.Shape
            /* 0x82E1 */ "StrokeDashArray", // Windows.UI.Xaml.Shapes.Shape
            /* 0x82E2 */ "StrokeDashCap", // Windows.UI.Xaml.Shapes.Shape
            /* 0x82E3 */ "StrokeDashOffset", // Windows.UI.Xaml.Shapes.Shape
            /* 0x82E4 */ "StrokeEndLineCap", // Windows.UI.Xaml.Shapes.Shape
            /* 0x82E5 */ "StrokeLineJoin", // Windows.UI.Xaml.Shapes.Shape
            /* 0x82E6 */ "StrokeMiterLimit", // Windows.UI.Xaml.Shapes.Shape
            /* 0x82E7 */ "StrokeStartLineCap", // Windows.UI.Xaml.Shapes.Shape
            /* 0x82E8 */ "StrokeThickness", // Windows.UI.Xaml.Shapes.Shape
            /* 0x82E9 */ "AngleX", // Windows.UI.Xaml.Media.SkewTransform
            /* 0x82EA */ "AngleY", // Windows.UI.Xaml.Media.SkewTransform
            /* 0x82EB */ "CenterX", // Windows.UI.Xaml.Media.SkewTransform
            /* 0x82EC */ "CenterY", // Windows.UI.Xaml.Media.SkewTransform
            /* 0x82ED */ "Inlines", // Windows.UI.Xaml.Documents.Span
            /* 0x82EE */ "ClosedLength", // Windows.UI.Xaml.Media.Animation.SplitCloseThemeAnimation
            /* 0x82EF */ "ClosedTarget", // Windows.UI.Xaml.Media.Animation.SplitCloseThemeAnimation
            /* 0x82F0 */ "ClosedTargetName", // Windows.UI.Xaml.Media.Animation.SplitCloseThemeAnimation
            /* 0x82F1 */ "ContentTarget", // Windows.UI.Xaml.Media.Animation.SplitCloseThemeAnimation
            /* 0x82F2 */ "ContentTargetName", // Windows.UI.Xaml.Media.Animation.SplitCloseThemeAnimation
            /* 0x82F3 */ "ContentTranslationDirection", // Windows.UI.Xaml.Media.Animation.SplitCloseThemeAnimation
            /* 0x82F4 */ "ContentTranslationOffset", // Windows.UI.Xaml.Media.Animation.SplitCloseThemeAnimation
            /* 0x82F5 */ "OffsetFromCenter", // Windows.UI.Xaml.Media.Animation.SplitCloseThemeAnimation
            /* 0x82F6 */ "OpenedLength", // Windows.UI.Xaml.Media.Animation.SplitCloseThemeAnimation
            /* 0x82F7 */ "OpenedTarget", // Windows.UI.Xaml.Media.Animation.SplitCloseThemeAnimation
            /* 0x82F8 */ "OpenedTargetName", // Windows.UI.Xaml.Media.Animation.SplitCloseThemeAnimation
            /* 0x82F9 */ "ClosedLength", // Windows.UI.Xaml.Media.Animation.SplitOpenThemeAnimation
            /* 0x82FA */ "ClosedTarget", // Windows.UI.Xaml.Media.Animation.SplitOpenThemeAnimation
            /* 0x82FB */ "ClosedTargetName", // Windows.UI.Xaml.Media.Animation.SplitOpenThemeAnimation
            /* 0x82FC */ "ContentTarget", // Windows.UI.Xaml.Media.Animation.SplitOpenThemeAnimation
            /* 0x82FD */ "ContentTargetName", // Windows.UI.Xaml.Media.Animation.SplitOpenThemeAnimation
            /* 0x82FE */ "ContentTranslationDirection", // Windows.UI.Xaml.Media.Animation.SplitOpenThemeAnimation
            /* 0x82FF */ "ContentTranslationOffset", // Windows.UI.Xaml.Media.Animation.SplitOpenThemeAnimation
            /* 0x8300 */ "OffsetFromCenter", // Windows.UI.Xaml.Media.Animation.SplitOpenThemeAnimation
            /* 0x8301 */ "OpenedLength", // Windows.UI.Xaml.Media.Animation.SplitOpenThemeAnimation
            /* 0x8302 */ "OpenedTarget", // Windows.UI.Xaml.Media.Animation.SplitOpenThemeAnimation
            /* 0x8303 */ "OpenedTargetName", // Windows.UI.Xaml.Media.Animation.SplitOpenThemeAnimation
            /* 0x8304 */ "Children", // Windows.UI.Xaml.Media.Animation.Storyboard
            /* 0x8305 */ "IsEssential", // Windows.UI.Xaml.Media.Animation.Storyboard
            /* 0x8306 */ "TargetName", // Windows.UI.Xaml.Media.Animation.Storyboard
            /* 0x8307 */ "TargetProperty", // Windows.UI.Xaml.Media.Animation.Storyboard
            /* 0x8308 */ "FromHorizontalOffset", // Windows.UI.Xaml.Media.Animation.SwipeBackThemeAnimation
            /* 0x8309 */ "FromVerticalOffset", // Windows.UI.Xaml.Media.Animation.SwipeBackThemeAnimation
            /* 0x830A */ "TargetName", // Windows.UI.Xaml.Media.Animation.SwipeBackThemeAnimation
            /* 0x830B */ "TargetName", // Windows.UI.Xaml.Media.Animation.SwipeHintThemeAnimation
            /* 0x830C */ "ToHorizontalOffset", // Windows.UI.Xaml.Media.Animation.SwipeHintThemeAnimation
            /* 0x830D */ "ToVerticalOffset", // Windows.UI.Xaml.Media.Animation.SwipeHintThemeAnimation
            /* 0x830E */ "CharacterSpacing", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x830F */ "FontFamily", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x8310 */ "FontSize", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x8311 */ "FontStretch", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x8312 */ "FontStyle", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x8313 */ "FontWeight", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x8314 */ "Foreground", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x8315 */ "Inlines", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x8316 */ "IsColorFontEnabled", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x8317 */ "IsTextScaleFactorEnabled", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x8318 */ "IsTextSelectionEnabled", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x8319 */ "LineHeight", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x831A */ "LineStackingStrategy", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x831B */ "MaxLines", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x831C */ "OpticalMarginAlignment", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x831D */ "Padding", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x831E */ "SelectedText", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x831F */ "SelectionHighlightColor", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x8320 */ "Text", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x8321 */ "TextAlignment", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x8322 */ "TextDecorations", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x8323 */ "TextLineBounds", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x8324 */ "TextReadingOrder", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x8325 */ "TextTrimming", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x8326 */ "TextWrapping", // Windows.UI.Xaml.Controls.TextBlock
            /* 0x8327 */ "ContentProperty", // Windows.UI.Xaml.Documents.TextElementCollection
            /* 0x8328 */ "ContentProperty", // Windows.UI.Xaml.Media.Animation.TimelineCollection
            /* 0x8329 */ "ContentProperty", // Windows.UI.Xaml.Media.TimelineMarkerCollection
            /* 0x832A */ "ContentProperty", // Windows.UI.Xaml.Media.TransformCollection
            /* 0x832B */ "Children", // Windows.UI.Xaml.Media.TransformGroup
            /* 0x832C */ "Value", // Windows.UI.Xaml.Media.TransformGroup
            /* 0x832D */ "ContentProperty", // Windows.UI.Xaml.Media.Animation.TransitionCollection
            /* 0x832E */ "X", // Windows.UI.Xaml.Media.TranslateTransform
            /* 0x832F */ "Y", // Windows.UI.Xaml.Media.TranslateTransform
            /* 0x8330 */ "ContentProperty", // Windows.UI.Xaml.TriggerActionCollection
            /* 0x8331 */ "ContentProperty", // Windows.UI.Xaml.TriggerCollection
            /* 0x8332 */ "ContentProperty", // Windows.UI.Xaml.Controls.UIElementCollection
            /* 0x8333 */ "Child", // Windows.UI.Xaml.Controls.Viewbox
            /* 0x8334 */ "Stretch", // Windows.UI.Xaml.Controls.Viewbox
            /* 0x8335 */ "StretchDirection", // Windows.UI.Xaml.Controls.Viewbox
            /* 0x8336 */ "ContentProperty", // Windows.UI.Xaml.Internal.VisualStateCollection
            /* 0x8337 */ "ContentProperty", // Windows.UI.Xaml.Internal.VisualStateGroupCollection
            /* 0x8338 */ "ContentProperty", // Windows.UI.Xaml.Internal.VisualTransitionCollection
            /* 0x8339 */ "SourceName", // Windows.UI.Xaml.Controls.WebViewBrush
            /* 0x833A */ "IsCompact", // Windows.UI.Xaml.Controls.AppBarSeparator
            /* 0x833B */ "UriSource", // Windows.UI.Xaml.Controls.BitmapIcon
            /* 0x833C */ "Left", // Windows.UI.Xaml.Controls.Canvas
            /* 0x833D */ "Top", // Windows.UI.Xaml.Controls.Canvas
            /* 0x833E */ "ZIndex", // Windows.UI.Xaml.Controls.Canvas
            /* 0x833F */ "ContentProperty", // Windows.UI.Xaml.Controls.CommandBarElementCollection
            /* 0x8340 */ "Content", // Windows.UI.Xaml.Controls.ContentControl
            /* 0x8341 */ "ContentTemplate", // Windows.UI.Xaml.Controls.ContentControl
            /* 0x8342 */ "ContentTemplateSelector", // Windows.UI.Xaml.Controls.ContentControl
            /* 0x8343 */ "ContentTransitions", // Windows.UI.Xaml.Controls.ContentControl
            /* 0x8344 */ "SelectedContentTemplate", // Windows.UI.Xaml.Controls.ContentControl
            /* 0x8345 */ "CalendarIdentifier", // Windows.UI.Xaml.Controls.DatePicker
            /* 0x8346 */ "Date", // Windows.UI.Xaml.Controls.DatePicker
            /* 0x8347 */ "DayFormat", // Windows.UI.Xaml.Controls.DatePicker
            /* 0x8348 */ "DayVisible", // Windows.UI.Xaml.Controls.DatePicker
            /* 0x8349 */ "Header", // Windows.UI.Xaml.Controls.DatePicker
            /* 0x834A */ "HeaderTemplate", // Windows.UI.Xaml.Controls.DatePicker
            /* 0x834B */ "MaxYear", // Windows.UI.Xaml.Controls.DatePicker
            /* 0x834C */ "MinYear", // Windows.UI.Xaml.Controls.DatePicker
            /* 0x834D */ "MonthFormat", // Windows.UI.Xaml.Controls.DatePicker
            /* 0x834E */ "MonthVisible", // Windows.UI.Xaml.Controls.DatePicker
            /* 0x834F */ "Orientation", // Windows.UI.Xaml.Controls.DatePicker
            /* 0x8350 */ "YearFormat", // Windows.UI.Xaml.Controls.DatePicker
            /* 0x8351 */ "YearVisible", // Windows.UI.Xaml.Controls.DatePicker
            /* 0x8352 */ "ContentProperty", // Windows.UI.Xaml.DependencyObjectCollection
            /* 0x8353 */ "FontFamily", // Windows.UI.Xaml.Controls.FontIcon
            /* 0x8354 */ "FontSize", // Windows.UI.Xaml.Controls.FontIcon
            /* 0x8355 */ "FontStyle", // Windows.UI.Xaml.Controls.FontIcon
            /* 0x8356 */ "FontWeight", // Windows.UI.Xaml.Controls.FontIcon
            /* 0x8357 */ "Glyph", // Windows.UI.Xaml.Controls.FontIcon
            /* 0x8358 */ "IsTextScaleFactorEnabled", // Windows.UI.Xaml.Controls.FontIcon
            /* 0x8359 */ "Column", // Windows.UI.Xaml.Controls.Grid
            /* 0x835A */ "ColumnDefinitions", // Windows.UI.Xaml.Controls.Grid
            /* 0x835B */ "ColumnSpan", // Windows.UI.Xaml.Controls.Grid
            /* 0x835C */ "Row", // Windows.UI.Xaml.Controls.Grid
            /* 0x835D */ "RowDefinitions", // Windows.UI.Xaml.Controls.Grid
            /* 0x835E */ "RowSpan", // Windows.UI.Xaml.Controls.Grid
            /* 0x835F */ "DefaultSectionIndex", // Windows.UI.Xaml.Controls.Hub
            /* 0x8360 */ "Header", // Windows.UI.Xaml.Controls.Hub
            /* 0x8361 */ "HeaderTemplate", // Windows.UI.Xaml.Controls.Hub
            /* 0x8362 */ "IsActiveView", // Windows.UI.Xaml.Controls.Hub
            /* 0x8363 */ "IsZoomedInView", // Windows.UI.Xaml.Controls.Hub
            /* 0x8364 */ "Orientation", // Windows.UI.Xaml.Controls.Hub
            /* 0x8365 */ "SectionHeaders", // Windows.UI.Xaml.Controls.Hub
            /* 0x8366 */ "Sections", // Windows.UI.Xaml.Controls.Hub
            /* 0x8367 */ "SectionsInView", // Windows.UI.Xaml.Controls.Hub
            /* 0x8368 */ "SemanticZoomOwner", // Windows.UI.Xaml.Controls.Hub
            /* 0x8369 */ "ContentTemplate", // Windows.UI.Xaml.Controls.HubSection
            /* 0x836A */ "Header", // Windows.UI.Xaml.Controls.HubSection
            /* 0x836B */ "HeaderTemplate", // Windows.UI.Xaml.Controls.HubSection
            /* 0x836C */ "IsHeaderInteractive", // Windows.UI.Xaml.Controls.HubSection
            /* 0x836D */ "NavigateUri", // Windows.UI.Xaml.Documents.Hyperlink
            /* 0x836E */ "ContentProperty", // Windows.UI.Xaml.Controls.ItemCollection
            /* 0x836F */ "DisplayMemberPath", // Windows.UI.Xaml.Controls.ItemsControl
            /* 0x8370 */ "GroupStyle", // Windows.UI.Xaml.Controls.ItemsControl
            /* 0x8371 */ "GroupStyleSelector", // Windows.UI.Xaml.Controls.ItemsControl
            /* 0x8372 */ "IsGrouping", // Windows.UI.Xaml.Controls.ItemsControl
            /* 0x8373 */ "IsItemsHostInvalid", // Windows.UI.Xaml.Controls.ItemsControl
            /* 0x8374 */ "ItemContainerStyle", // Windows.UI.Xaml.Controls.ItemsControl
            /* 0x8375 */ "ItemContainerStyleSelector", // Windows.UI.Xaml.Controls.ItemsControl
            /* 0x8376 */ "ItemContainerTransitions", // Windows.UI.Xaml.Controls.ItemsControl
            /* 0x8377 */ "Items", // Windows.UI.Xaml.Controls.ItemsControl
            /* 0x8378 */ "ItemsHost", // Windows.UI.Xaml.Controls.ItemsControl
            /* 0x8379 */ "ItemsPanel", // Windows.UI.Xaml.Controls.ItemsControl
            /* 0x837A */ "ItemsSource", // Windows.UI.Xaml.Controls.ItemsControl
            /* 0x837B */ "ItemTemplate", // Windows.UI.Xaml.Controls.ItemsControl
            /* 0x837C */ "ItemTemplateSelector", // Windows.UI.Xaml.Controls.ItemsControl
            /* 0x837D */ "X1", // Windows.UI.Xaml.Shapes.Line
            /* 0x837E */ "X2", // Windows.UI.Xaml.Shapes.Line
            /* 0x837F */ "Y1", // Windows.UI.Xaml.Shapes.Line
            /* 0x8380 */ "Y2", // Windows.UI.Xaml.Shapes.Line
            /* 0x8381 */ null,
            /* 0x8382 */ "IsFastForwardButtonVisible", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x8383 */ null,
            /* 0x8384 */ "IsFastRewindButtonVisible", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x8385 */ null,
            /* 0x8386 */ "IsFullWindowButtonVisible", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x8387 */ null,
            /* 0x8388 */ "IsPlaybackRateButtonVisible", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x8389 */ "IsSeekBarVisible", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x838A */ null,
            /* 0x838B */ null,
            /* 0x838C */ "IsStopButtonVisible", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x838D */ null,
            /* 0x838E */ "IsVolumeButtonVisible", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x838F */ null,
            /* 0x8390 */ "IsZoomButtonVisible", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x8391 */ "Header", // Windows.UI.Xaml.Controls.PasswordBox
            /* 0x8392 */ "HeaderTemplate", // Windows.UI.Xaml.Controls.PasswordBox
            /* 0x8393 */ "IsPasswordRevealButtonEnabled", // Windows.UI.Xaml.Controls.PasswordBox
            /* 0x8394 */ "MaxLength", // Windows.UI.Xaml.Controls.PasswordBox
            /* 0x8395 */ "Password", // Windows.UI.Xaml.Controls.PasswordBox
            /* 0x8396 */ "PasswordChar", // Windows.UI.Xaml.Controls.PasswordBox
            /* 0x8397 */ "PlaceholderText", // Windows.UI.Xaml.Controls.PasswordBox
            /* 0x8398 */ "PreventKeyboardDisplayOnProgrammaticFocus", // Windows.UI.Xaml.Controls.PasswordBox
            /* 0x8399 */ "SelectionHighlightColor", // Windows.UI.Xaml.Controls.PasswordBox
            /* 0x839A */ "Data", // Windows.UI.Xaml.Shapes.Path
            /* 0x839B */ "Data", // Windows.UI.Xaml.Controls.PathIcon
            /* 0x839C */ "FillRule", // Windows.UI.Xaml.Shapes.Polygon
            /* 0x839D */ "Points", // Windows.UI.Xaml.Shapes.Polygon
            /* 0x839E */ "FillRule", // Windows.UI.Xaml.Shapes.Polyline
            /* 0x839F */ "Points", // Windows.UI.Xaml.Shapes.Polyline
            /* 0x83A0 */ "IsActive", // Windows.UI.Xaml.Controls.ProgressRing
            /* 0x83A1 */ "TemplateSettings", // Windows.UI.Xaml.Controls.ProgressRing
            /* 0x83A2 */ "LargeChange", // Windows.UI.Xaml.Controls.Primitives.RangeBase
            /* 0x83A3 */ "Maximum", // Windows.UI.Xaml.Controls.Primitives.RangeBase
            /* 0x83A4 */ "Minimum", // Windows.UI.Xaml.Controls.Primitives.RangeBase
            /* 0x83A5 */ "SmallChange", // Windows.UI.Xaml.Controls.Primitives.RangeBase
            /* 0x83A6 */ "Value", // Windows.UI.Xaml.Controls.Primitives.RangeBase
            /* 0x83A7 */ "RadiusX", // Windows.UI.Xaml.Shapes.Rectangle
            /* 0x83A8 */ "RadiusY", // Windows.UI.Xaml.Shapes.Rectangle
            /* 0x83A9 */ "AcceptsReturn", // Windows.UI.Xaml.Controls.RichEditBox
            /* 0x83AA */ "Header", // Windows.UI.Xaml.Controls.RichEditBox
            /* 0x83AB */ "HeaderTemplate", // Windows.UI.Xaml.Controls.RichEditBox
            /* 0x83AC */ "InputScope", // Windows.UI.Xaml.Controls.RichEditBox
            /* 0x83AD */ "IsColorFontEnabled", // Windows.UI.Xaml.Controls.RichEditBox
            /* 0x83AE */ "IsReadOnly", // Windows.UI.Xaml.Controls.RichEditBox
            /* 0x83AF */ "IsSpellCheckEnabled", // Windows.UI.Xaml.Controls.RichEditBox
            /* 0x83B0 */ "IsTextPredictionEnabled", // Windows.UI.Xaml.Controls.RichEditBox
            /* 0x83B1 */ "PlaceholderText", // Windows.UI.Xaml.Controls.RichEditBox
            /* 0x83B2 */ "PreventKeyboardDisplayOnProgrammaticFocus", // Windows.UI.Xaml.Controls.RichEditBox
            /* 0x83B3 */ "SelectionHighlightColor", // Windows.UI.Xaml.Controls.RichEditBox
            /* 0x83B4 */ "TextAlignment", // Windows.UI.Xaml.Controls.RichEditBox
            /* 0x83B5 */ "TextWrapping", // Windows.UI.Xaml.Controls.RichEditBox
            /* 0x83B6 */ "ChooseSuggestionOnEnter", // Windows.UI.Xaml.Controls.SearchBox
            /* 0x83B7 */ "FocusOnKeyboardInput", // Windows.UI.Xaml.Controls.SearchBox
            /* 0x83B8 */ "PlaceholderText", // Windows.UI.Xaml.Controls.SearchBox
            /* 0x83B9 */ "QueryText", // Windows.UI.Xaml.Controls.SearchBox
            /* 0x83BA */ "SearchHistoryContext", // Windows.UI.Xaml.Controls.SearchBox
            /* 0x83BB */ "SearchHistoryEnabled", // Windows.UI.Xaml.Controls.SearchBox
            /* 0x83BC */ "CanChangeViews", // Windows.UI.Xaml.Controls.SemanticZoom
            /* 0x83BD */ "IsZoomedInViewActive", // Windows.UI.Xaml.Controls.SemanticZoom
            /* 0x83BE */ "IsZoomOutButtonEnabled", // Windows.UI.Xaml.Controls.SemanticZoom
            /* 0x83BF */ "ZoomedInView", // Windows.UI.Xaml.Controls.SemanticZoom
            /* 0x83C0 */ "ZoomedOutView", // Windows.UI.Xaml.Controls.SemanticZoom
            /* 0x83C1 */ "AreScrollSnapPointsRegular", // Windows.UI.Xaml.Controls.StackPanel
            /* 0x83C2 */ "Orientation", // Windows.UI.Xaml.Controls.StackPanel
            /* 0x83C3 */ "Symbol", // Windows.UI.Xaml.Controls.SymbolIcon
            /* 0x83C4 */ "AcceptsReturn", // Windows.UI.Xaml.Controls.TextBox
            /* 0x83C5 */ "Header", // Windows.UI.Xaml.Controls.TextBox
            /* 0x83C6 */ "HeaderTemplate", // Windows.UI.Xaml.Controls.TextBox
            /* 0x83C7 */ "InputScope", // Windows.UI.Xaml.Controls.TextBox
            /* 0x83C8 */ "IsColorFontEnabled", // Windows.UI.Xaml.Controls.TextBox
            /* 0x83C9 */ "IsCoreDesktopPopupMenuEnabled", // Windows.UI.Xaml.Controls.TextBox
            /* 0x83CA */ null,
            /* 0x83CB */ "IsReadOnly", // Windows.UI.Xaml.Controls.TextBox
            /* 0x83CC */ "IsSpellCheckEnabled", // Windows.UI.Xaml.Controls.TextBox
            /* 0x83CD */ "IsTextPredictionEnabled", // Windows.UI.Xaml.Controls.TextBox
            /* 0x83CE */ "MaxLength", // Windows.UI.Xaml.Controls.TextBox
            /* 0x83CF */ "PlaceholderText", // Windows.UI.Xaml.Controls.TextBox
            /* 0x83D0 */ "PreventKeyboardDisplayOnProgrammaticFocus", // Windows.UI.Xaml.Controls.TextBox
            /* 0x83D1 */ "SelectedText", // Windows.UI.Xaml.Controls.TextBox
            /* 0x83D2 */ "SelectionHighlightColor", // Windows.UI.Xaml.Controls.TextBox
            /* 0x83D3 */ "SelectionLength", // Windows.UI.Xaml.Controls.TextBox
            /* 0x83D4 */ "SelectionStart", // Windows.UI.Xaml.Controls.TextBox
            /* 0x83D5 */ "Text", // Windows.UI.Xaml.Controls.TextBox
            /* 0x83D6 */ "TextAlignment", // Windows.UI.Xaml.Controls.TextBox
            /* 0x83D7 */ "TextWrapping", // Windows.UI.Xaml.Controls.TextBox
            /* 0x83D8 */ "IsDragging", // Windows.UI.Xaml.Controls.Primitives.Thumb
            /* 0x83D9 */ "Fill", // Windows.UI.Xaml.Controls.Primitives.TickBar
            /* 0x83DA */ "ClockIdentifier", // Windows.UI.Xaml.Controls.TimePicker
            /* 0x83DB */ "Header", // Windows.UI.Xaml.Controls.TimePicker
            /* 0x83DC */ "HeaderTemplate", // Windows.UI.Xaml.Controls.TimePicker
            /* 0x83DD */ "MinuteIncrement", // Windows.UI.Xaml.Controls.TimePicker
            /* 0x83DE */ "Time", // Windows.UI.Xaml.Controls.TimePicker
            /* 0x83DF */ "Header", // Windows.UI.Xaml.Controls.ToggleSwitch
            /* 0x83E0 */ "HeaderTemplate", // Windows.UI.Xaml.Controls.ToggleSwitch
            /* 0x83E1 */ "IsOn", // Windows.UI.Xaml.Controls.ToggleSwitch
            /* 0x83E2 */ "OffContent", // Windows.UI.Xaml.Controls.ToggleSwitch
            /* 0x83E3 */ "OffContentTemplate", // Windows.UI.Xaml.Controls.ToggleSwitch
            /* 0x83E4 */ "OnContent", // Windows.UI.Xaml.Controls.ToggleSwitch
            /* 0x83E5 */ "OnContentTemplate", // Windows.UI.Xaml.Controls.ToggleSwitch
            /* 0x83E6 */ "TemplateSettings", // Windows.UI.Xaml.Controls.ToggleSwitch
            /* 0x83E7 */ "Content", // Windows.UI.Xaml.Controls.UserControl
            /* 0x83E8 */ "ColumnSpan", // Windows.UI.Xaml.Controls.VariableSizedWrapGrid
            /* 0x83E9 */ "HorizontalChildrenAlignment", // Windows.UI.Xaml.Controls.VariableSizedWrapGrid
            /* 0x83EA */ "ItemHeight", // Windows.UI.Xaml.Controls.VariableSizedWrapGrid
            /* 0x83EB */ "ItemWidth", // Windows.UI.Xaml.Controls.VariableSizedWrapGrid
            /* 0x83EC */ "MaximumRowsOrColumns", // Windows.UI.Xaml.Controls.VariableSizedWrapGrid
            /* 0x83ED */ "Orientation", // Windows.UI.Xaml.Controls.VariableSizedWrapGrid
            /* 0x83EE */ "RowSpan", // Windows.UI.Xaml.Controls.VariableSizedWrapGrid
            /* 0x83EF */ "VerticalChildrenAlignment", // Windows.UI.Xaml.Controls.VariableSizedWrapGrid
            /* 0x83F0 */ "AllowedScriptNotifyUris", // Windows.UI.Xaml.Controls.WebView
            /* 0x83F1 */ "CanGoBack", // Windows.UI.Xaml.Controls.WebView
            /* 0x83F2 */ "CanGoForward", // Windows.UI.Xaml.Controls.WebView
            /* 0x83F3 */ "ContainsFullScreenElement", // Windows.UI.Xaml.Controls.WebView
            /* 0x83F4 */ "DataTransferPackage", // Windows.UI.Xaml.Controls.WebView
            /* 0x83F5 */ "DefaultBackgroundColor", // Windows.UI.Xaml.Controls.WebView
            /* 0x83F6 */ "DocumentTitle", // Windows.UI.Xaml.Controls.WebView
            /* 0x83F7 */ "Source", // Windows.UI.Xaml.Controls.WebView
            /* 0x83F8 */ "ClosedDisplayMode", // Windows.UI.Xaml.Controls.AppBar
            /* 0x83F9 */ "IsOpen", // Windows.UI.Xaml.Controls.AppBar
            /* 0x83FA */ "IsSticky", // Windows.UI.Xaml.Controls.AppBar
            /* 0x83FB */ "AutoMaximizeSuggestionArea", // Windows.UI.Xaml.Controls.AutoSuggestBox
            /* 0x83FC */ "Header", // Windows.UI.Xaml.Controls.AutoSuggestBox
            /* 0x83FD */ "IsSuggestionListOpen", // Windows.UI.Xaml.Controls.AutoSuggestBox
            /* 0x83FE */ "MaxSuggestionListHeight", // Windows.UI.Xaml.Controls.AutoSuggestBox
            /* 0x83FF */ "PlaceholderText", // Windows.UI.Xaml.Controls.AutoSuggestBox
            /* 0x8400 */ "Text", // Windows.UI.Xaml.Controls.AutoSuggestBox
            /* 0x8401 */ "TextBoxStyle", // Windows.UI.Xaml.Controls.AutoSuggestBox
            /* 0x8402 */ "TextMemberPath", // Windows.UI.Xaml.Controls.AutoSuggestBox
            /* 0x8403 */ "UpdateTextOnSelect", // Windows.UI.Xaml.Controls.AutoSuggestBox
            /* 0x8404 */ "ContentProperty", // Windows.UI.Xaml.Documents.BlockCollection
            /* 0x8405 */ "ClickMode", // Windows.UI.Xaml.Controls.Primitives.ButtonBase
            /* 0x8406 */ "Command", // Windows.UI.Xaml.Controls.Primitives.ButtonBase
            /* 0x8407 */ "CommandParameter", // Windows.UI.Xaml.Controls.Primitives.ButtonBase
            /* 0x8408 */ "IsPointerOver", // Windows.UI.Xaml.Controls.Primitives.ButtonBase
            /* 0x8409 */ "IsPressed", // Windows.UI.Xaml.Controls.Primitives.ButtonBase
            /* 0x840A */ "FullSizeDesired", // Windows.UI.Xaml.Controls.ContentDialog
            /* 0x840B */ "IsPrimaryButtonEnabled", // Windows.UI.Xaml.Controls.ContentDialog
            /* 0x840C */ "IsSecondaryButtonEnabled", // Windows.UI.Xaml.Controls.ContentDialog
            /* 0x840D */ "PrimaryButtonCommand", // Windows.UI.Xaml.Controls.ContentDialog
            /* 0x840E */ "PrimaryButtonCommandParameter", // Windows.UI.Xaml.Controls.ContentDialog
            /* 0x840F */ "PrimaryButtonText", // Windows.UI.Xaml.Controls.ContentDialog
            /* 0x8410 */ "SecondaryButtonCommand", // Windows.UI.Xaml.Controls.ContentDialog
            /* 0x8411 */ "SecondaryButtonCommandParameter", // Windows.UI.Xaml.Controls.ContentDialog
            /* 0x8412 */ "SecondaryButtonText", // Windows.UI.Xaml.Controls.ContentDialog
            /* 0x8413 */ "Title", // Windows.UI.Xaml.Controls.ContentDialog
            /* 0x8414 */ "TitleTemplate", // Windows.UI.Xaml.Controls.ContentDialog
            /* 0x8415 */ "BackStack", // Windows.UI.Xaml.Controls.Frame
            /* 0x8416 */ "BackStackDepth", // Windows.UI.Xaml.Controls.Frame
            /* 0x8417 */ "CacheSize", // Windows.UI.Xaml.Controls.Frame
            /* 0x8418 */ "CanGoBack", // Windows.UI.Xaml.Controls.Frame
            /* 0x8419 */ "CanGoForward", // Windows.UI.Xaml.Controls.Frame
            /* 0x841A */ "CurrentSourcePageType", // Windows.UI.Xaml.Controls.Frame
            /* 0x841B */ "ForwardStack", // Windows.UI.Xaml.Controls.Frame
            /* 0x841C */ "SourcePageType", // Windows.UI.Xaml.Controls.Frame
            /* 0x841D */ "CheckBrush", // Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter
            /* 0x841E */ "CheckHintBrush", // Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter
            /* 0x841F */ "CheckSelectingBrush", // Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter
            /* 0x8420 */ "ContentMargin", // Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter
            /* 0x8421 */ "DisabledOpacity", // Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter
            /* 0x8422 */ "DragBackground", // Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter
            /* 0x8423 */ "DragForeground", // Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter
            /* 0x8424 */ "DragOpacity", // Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter
            /* 0x8425 */ "FocusBorderBrush", // Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter
            /* 0x8426 */ "GridViewItemPresenterHorizontalContentAlignment", // Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter
            /* 0x8427 */ "GridViewItemPresenterPadding", // Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter
            /* 0x8428 */ "PlaceholderBackground", // Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter
            /* 0x8429 */ "PointerOverBackground", // Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter
            /* 0x842A */ "PointerOverBackgroundMargin", // Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter
            /* 0x842B */ "ReorderHintOffset", // Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter
            /* 0x842C */ "SelectedBackground", // Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter
            /* 0x842D */ "SelectedBorderThickness", // Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter
            /* 0x842E */ "SelectedForeground", // Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter
            /* 0x842F */ "SelectedPointerOverBackground", // Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter
            /* 0x8430 */ "SelectedPointerOverBorderBrush", // Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter
            /* 0x8431 */ "SelectionCheckMarkVisualEnabled", // Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter
            /* 0x8432 */ "GridViewItemPresenterVerticalContentAlignment", // Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter
            /* 0x8433 */ "ContentProperty", // Windows.UI.Xaml.Documents.InlineCollection
            /* 0x8434 */ "CacheLength", // Windows.UI.Xaml.Controls.ItemsStackPanel
            /* 0x8435 */ "GroupHeaderPlacement", // Windows.UI.Xaml.Controls.ItemsStackPanel
            /* 0x8436 */ "GroupPadding", // Windows.UI.Xaml.Controls.ItemsStackPanel
            /* 0x8437 */ "ItemsUpdatingScrollMode", // Windows.UI.Xaml.Controls.ItemsStackPanel
            /* 0x8438 */ "Orientation", // Windows.UI.Xaml.Controls.ItemsStackPanel
            /* 0x8439 */ "CacheLength", // Windows.UI.Xaml.Controls.ItemsWrapGrid
            /* 0x843A */ "GroupHeaderPlacement", // Windows.UI.Xaml.Controls.ItemsWrapGrid
            /* 0x843B */ "GroupPadding", // Windows.UI.Xaml.Controls.ItemsWrapGrid
            /* 0x843C */ "ItemHeight", // Windows.UI.Xaml.Controls.ItemsWrapGrid
            /* 0x843D */ "ItemWidth", // Windows.UI.Xaml.Controls.ItemsWrapGrid
            /* 0x843E */ "MaximumRowsOrColumns", // Windows.UI.Xaml.Controls.ItemsWrapGrid
            /* 0x843F */ "Orientation", // Windows.UI.Xaml.Controls.ItemsWrapGrid
            /* 0x8440 */ "CheckBrush", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x8441 */ "CheckHintBrush", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x8442 */ "CheckSelectingBrush", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x8443 */ "ContentMargin", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x8444 */ "DisabledOpacity", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x8445 */ "DragBackground", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x8446 */ "DragForeground", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x8447 */ "DragOpacity", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x8448 */ "FocusBorderBrush", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x8449 */ "ListViewItemPresenterHorizontalContentAlignment", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x844A */ "ListViewItemPresenterPadding", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x844B */ "PlaceholderBackground", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x844C */ "PointerOverBackground", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x844D */ "PointerOverBackgroundMargin", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x844E */ "ReorderHintOffset", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x844F */ "SelectedBackground", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x8450 */ "SelectedBorderThickness", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x8451 */ "SelectedForeground", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x8452 */ "SelectedPointerOverBackground", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x8453 */ "SelectedPointerOverBorderBrush", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x8454 */ "SelectionCheckMarkVisualEnabled", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x8455 */ "ListViewItemPresenterVerticalContentAlignment", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x8456 */ "Command", // Windows.UI.Xaml.Controls.MenuFlyoutItem
            /* 0x8457 */ "CommandParameter", // Windows.UI.Xaml.Controls.MenuFlyoutItem
            /* 0x8458 */ "Text", // Windows.UI.Xaml.Controls.MenuFlyoutItem
            /* 0x8459 */ "IsContainerGeneratedForInsert", // Windows.UI.Xaml.Controls.Primitives.OrientedVirtualizingPanel
            /* 0x845A */ "BottomAppBar", // Windows.UI.Xaml.Controls.Page
            /* 0x845B */ "Frame", // Windows.UI.Xaml.Controls.Page
            /* 0x845C */ "NavigationCacheMode", // Windows.UI.Xaml.Controls.Page
            /* 0x845D */ "TopAppBar", // Windows.UI.Xaml.Controls.Page
            /* 0x845E */ "IsIndeterminate", // Windows.UI.Xaml.Controls.ProgressBar
            /* 0x845F */ "ShowError", // Windows.UI.Xaml.Controls.ProgressBar
            /* 0x8460 */ "ShowPaused", // Windows.UI.Xaml.Controls.ProgressBar
            /* 0x8461 */ "TemplateSettings", // Windows.UI.Xaml.Controls.ProgressBar
            /* 0x8462 */ "IndicatorMode", // Windows.UI.Xaml.Controls.Primitives.ScrollBar
            /* 0x8463 */ "Orientation", // Windows.UI.Xaml.Controls.Primitives.ScrollBar
            /* 0x8464 */ "ViewportSize", // Windows.UI.Xaml.Controls.Primitives.ScrollBar
            /* 0x8465 */ "IsSelectionActive", // Windows.UI.Xaml.Controls.Primitives.Selector
            /* 0x8466 */ "IsSynchronizedWithCurrentItem", // Windows.UI.Xaml.Controls.Primitives.Selector
            /* 0x8467 */ "SelectedIndex", // Windows.UI.Xaml.Controls.Primitives.Selector
            /* 0x8468 */ "SelectedItem", // Windows.UI.Xaml.Controls.Primitives.Selector
            /* 0x8469 */ "SelectedValue", // Windows.UI.Xaml.Controls.Primitives.Selector
            /* 0x846A */ "SelectedValuePath", // Windows.UI.Xaml.Controls.Primitives.Selector
            /* 0x846B */ "IsSelected", // Windows.UI.Xaml.Controls.Primitives.SelectorItem
            /* 0x846C */ "HeaderBackground", // Windows.UI.Xaml.Controls.SettingsFlyout
            /* 0x846D */ "HeaderForeground", // Windows.UI.Xaml.Controls.SettingsFlyout
            /* 0x846E */ "IconSource", // Windows.UI.Xaml.Controls.SettingsFlyout
            /* 0x846F */ "TemplateSettings", // Windows.UI.Xaml.Controls.SettingsFlyout
            /* 0x8470 */ "Title", // Windows.UI.Xaml.Controls.SettingsFlyout
            /* 0x8471 */ "Header", // Windows.UI.Xaml.Controls.Slider
            /* 0x8472 */ "HeaderTemplate", // Windows.UI.Xaml.Controls.Slider
            /* 0x8473 */ "IntermediateValue", // Windows.UI.Xaml.Controls.Slider
            /* 0x8474 */ "IsDirectionReversed", // Windows.UI.Xaml.Controls.Slider
            /* 0x8475 */ "IsThumbToolTipEnabled", // Windows.UI.Xaml.Controls.Slider
            /* 0x8476 */ "Orientation", // Windows.UI.Xaml.Controls.Slider
            /* 0x8477 */ "SnapsTo", // Windows.UI.Xaml.Controls.Slider
            /* 0x8478 */ "StepFrequency", // Windows.UI.Xaml.Controls.Slider
            /* 0x8479 */ "ThumbToolTipValueConverter", // Windows.UI.Xaml.Controls.Slider
            /* 0x847A */ "TickFrequency", // Windows.UI.Xaml.Controls.Slider
            /* 0x847B */ "TickPlacement", // Windows.UI.Xaml.Controls.Slider
            /* 0x847C */ "CompositionScaleX", // Windows.UI.Xaml.Controls.SwapChainPanel
            /* 0x847D */ "CompositionScaleY", // Windows.UI.Xaml.Controls.SwapChainPanel
            /* 0x847E */ "HorizontalOffset", // Windows.UI.Xaml.Controls.ToolTip
            /* 0x847F */ "IsOpen", // Windows.UI.Xaml.Controls.ToolTip
            /* 0x8480 */ "Placement", // Windows.UI.Xaml.Controls.ToolTip
            /* 0x8481 */ "PlacementTarget", // Windows.UI.Xaml.Controls.ToolTip
            /* 0x8482 */ "TemplateSettings", // Windows.UI.Xaml.Controls.ToolTip
            /* 0x8483 */ "VerticalOffset", // Windows.UI.Xaml.Controls.ToolTip
            /* 0x8484 */ "Flyout", // Windows.UI.Xaml.Controls.Button
            /* 0x8485 */ "Header", // Windows.UI.Xaml.Controls.ComboBox
            /* 0x8486 */ "HeaderTemplate", // Windows.UI.Xaml.Controls.ComboBox
            /* 0x8487 */ "IsDropDownOpen", // Windows.UI.Xaml.Controls.ComboBox
            /* 0x8488 */ "IsEditable", // Windows.UI.Xaml.Controls.ComboBox
            /* 0x8489 */ "IsSelectionBoxHighlighted", // Windows.UI.Xaml.Controls.ComboBox
            /* 0x848A */ "MaxDropDownHeight", // Windows.UI.Xaml.Controls.ComboBox
            /* 0x848B */ "PlaceholderText", // Windows.UI.Xaml.Controls.ComboBox
            /* 0x848C */ "SelectionBoxItem", // Windows.UI.Xaml.Controls.ComboBox
            /* 0x848D */ "SelectionBoxItemTemplate", // Windows.UI.Xaml.Controls.ComboBox
            /* 0x848E */ "TemplateSettings", // Windows.UI.Xaml.Controls.ComboBox
            /* 0x848F */ "PrimaryCommands", // Windows.UI.Xaml.Controls.CommandBar
            /* 0x8490 */ "SecondaryCommands", // Windows.UI.Xaml.Controls.CommandBar
            /* 0x8491 */ "UseTouchAnimationsForAllNavigation", // Windows.UI.Xaml.Controls.FlipView
            /* 0x8492 */ "NavigateUri", // Windows.UI.Xaml.Controls.HyperlinkButton
            /* 0x8493 */ "SelectedItems", // Windows.UI.Xaml.Controls.ListBox
            /* 0x8494 */ "SelectionMode", // Windows.UI.Xaml.Controls.ListBox
            /* 0x8495 */ "CanDragItems", // Windows.UI.Xaml.Controls.ListViewBase
            /* 0x8496 */ "CanReorderItems", // Windows.UI.Xaml.Controls.ListViewBase
            /* 0x8497 */ "DataFetchSize", // Windows.UI.Xaml.Controls.ListViewBase
            /* 0x8498 */ "Footer", // Windows.UI.Xaml.Controls.ListViewBase
            /* 0x8499 */ "FooterTemplate", // Windows.UI.Xaml.Controls.ListViewBase
            /* 0x849A */ "FooterTransitions", // Windows.UI.Xaml.Controls.ListViewBase
            /* 0x849B */ "Header", // Windows.UI.Xaml.Controls.ListViewBase
            /* 0x849C */ "HeaderTemplate", // Windows.UI.Xaml.Controls.ListViewBase
            /* 0x849D */ "HeaderTransitions", // Windows.UI.Xaml.Controls.ListViewBase
            /* 0x849E */ "IncrementalLoadingThreshold", // Windows.UI.Xaml.Controls.ListViewBase
            /* 0x849F */ "IncrementalLoadingTrigger", // Windows.UI.Xaml.Controls.ListViewBase
            /* 0x84A0 */ "IsActiveView", // Windows.UI.Xaml.Controls.ListViewBase
            /* 0x84A1 */ "IsItemClickEnabled", // Windows.UI.Xaml.Controls.ListViewBase
            /* 0x84A2 */ "IsSwipeEnabled", // Windows.UI.Xaml.Controls.ListViewBase
            /* 0x84A3 */ "IsZoomedInView", // Windows.UI.Xaml.Controls.ListViewBase
            /* 0x84A4 */ "ReorderMode", // Windows.UI.Xaml.Controls.ListViewBase
            /* 0x84A5 */ "SelectedItems", // Windows.UI.Xaml.Controls.ListViewBase
            /* 0x84A6 */ "SelectionMode", // Windows.UI.Xaml.Controls.ListViewBase
            /* 0x84A7 */ "SemanticZoomOwner", // Windows.UI.Xaml.Controls.ListViewBase
            /* 0x84A8 */ "ShowsScrollingPlaceholders", // Windows.UI.Xaml.Controls.ListViewBase
            /* 0x84A9 */ "Delay", // Windows.UI.Xaml.Controls.Primitives.RepeatButton
            /* 0x84AA */ "Interval", // Windows.UI.Xaml.Controls.Primitives.RepeatButton
            /* 0x84AB */ "BringIntoViewOnFocusChange", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84AC */ "ComputedHorizontalScrollBarVisibility", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84AD */ "ComputedVerticalScrollBarVisibility", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84AE */ "ExtentHeight", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84AF */ "ExtentWidth", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84B0 */ "HorizontalOffset", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84B1 */ "HorizontalScrollBarVisibility", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84B2 */ "HorizontalScrollMode", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84B3 */ "HorizontalSnapPointsAlignment", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84B4 */ "HorizontalSnapPointsType", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84B5 */ "IsDeferredScrollingEnabled", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84B6 */ "IsHorizontalRailEnabled", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84B7 */ "IsHorizontalScrollChainingEnabled", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84B8 */ "IsScrollInertiaEnabled", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84B9 */ "IsVerticalRailEnabled", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84BA */ "IsVerticalScrollChainingEnabled", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84BB */ "IsZoomChainingEnabled", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84BC */ "IsZoomInertiaEnabled", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84BD */ "LeftHeader", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84BE */ "MaxZoomFactor", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84BF */ "MinZoomFactor", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84C0 */ "ScrollableHeight", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84C1 */ "ScrollableWidth", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84C2 */ "TopHeader", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84C3 */ "TopLeftHeader", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84C4 */ "VerticalOffset", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84C5 */ "VerticalScrollBarVisibility", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84C6 */ "VerticalScrollMode", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84C7 */ "VerticalSnapPointsAlignment", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84C8 */ "VerticalSnapPointsType", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84C9 */ "ViewportHeight", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84CA */ "ViewportWidth", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84CB */ "ZoomFactor", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84CC */ "ZoomMode", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84CD */ "ZoomSnapPoints", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84CE */ "ZoomSnapPointsType", // Windows.UI.Xaml.Controls.ScrollViewer
            /* 0x84CF */ "IsChecked", // Windows.UI.Xaml.Controls.Primitives.ToggleButton
            /* 0x84D0 */ "IsThreeState", // Windows.UI.Xaml.Controls.Primitives.ToggleButton
            /* 0x84D1 */ "IsChecked", // Windows.UI.Xaml.Controls.ToggleMenuFlyoutItem
            /* 0x84D2 */ "AreScrollSnapPointsRegular", // Windows.UI.Xaml.Controls.VirtualizingStackPanel
            /* 0x84D3 */ "IsContainerGeneratedForInsert", // Windows.UI.Xaml.Controls.VirtualizingStackPanel
            /* 0x84D4 */ "IsVirtualizing", // Windows.UI.Xaml.Controls.VirtualizingStackPanel
            /* 0x84D5 */ "Orientation", // Windows.UI.Xaml.Controls.VirtualizingStackPanel
            /* 0x84D6 */ "VirtualizationMode", // Windows.UI.Xaml.Controls.VirtualizingStackPanel
            /* 0x84D7 */ "HorizontalChildrenAlignment", // Windows.UI.Xaml.Controls.WrapGrid
            /* 0x84D8 */ "ItemHeight", // Windows.UI.Xaml.Controls.WrapGrid
            /* 0x84D9 */ "ItemWidth", // Windows.UI.Xaml.Controls.WrapGrid
            /* 0x84DA */ "MaximumRowsOrColumns", // Windows.UI.Xaml.Controls.WrapGrid
            /* 0x84DB */ "Orientation", // Windows.UI.Xaml.Controls.WrapGrid
            /* 0x84DC */ "VerticalChildrenAlignment", // Windows.UI.Xaml.Controls.WrapGrid
            /* 0x84DD */ "Icon", // Windows.UI.Xaml.Controls.AppBarButton
            /* 0x84DE */ "IsCompact", // Windows.UI.Xaml.Controls.AppBarButton
            /* 0x84DF */ "Label", // Windows.UI.Xaml.Controls.AppBarButton
            /* 0x84E0 */ "Icon", // Windows.UI.Xaml.Controls.AppBarToggleButton
            /* 0x84E1 */ "IsCompact", // Windows.UI.Xaml.Controls.AppBarToggleButton
            /* 0x84E2 */ "Label", // Windows.UI.Xaml.Controls.AppBarToggleButton
            /* 0x84E3 */ "TemplateSettings", // Windows.UI.Xaml.Controls.GridViewItem
            /* 0x84E4 */ "TemplateSettings", // Windows.UI.Xaml.Controls.ListViewItem
            /* 0x84E5 */ "GroupName", // Windows.UI.Xaml.Controls.RadioButton
            /* 0x84E6 */ "ActiveStoryboards", // Windows.UI.Xaml.Internal.VisualStateGroupCollection
            /* 0x84E7 */ "ActiveTransitions", // Windows.UI.Xaml.Internal.VisualStateGroupCollection
            /* 0x84E8 */ null,
            /* 0x84E9 */ null,
            /* 0x84EA */ null,
            /* 0x84EB */ null,
            /* 0x84EC */ null,
            /* 0x84ED */ null,
            /* 0x84EE */ null,
            /* 0x84EF */ null,
            /* 0x84F0 */ null,
            /* 0x84F1 */ "ContentProperty", // Windows.UI.Xaml.Internal.StoryboardCollection
            /* 0x84F2 */ "CacheLength", // Windows.UI.Xaml.Controls.PluggableLayoutPanel
            /* 0x84F3 */ "ColorFontPaletteIndex", // Windows.UI.Xaml.Documents.Glyphs
            /* 0x84F4 */ "IsColorFontEnabled", // Windows.UI.Xaml.Documents.Glyphs
            /* 0x84F5 */ null,
            /* 0x84F6 */ null,
            /* 0x84F7 */ null,
            /* 0x84F8 */ null,
            /* 0x84F9 */ null,
            /* 0x84FA */ "HasMoreContentAfter", // Windows.UI.Xaml.Controls.Primitives.CalendarViewTemplateSettings
            /* 0x84FB */ "HasMoreContentBefore", // Windows.UI.Xaml.Controls.Primitives.CalendarViewTemplateSettings
            /* 0x84FC */ "HasMoreViews", // Windows.UI.Xaml.Controls.Primitives.CalendarViewTemplateSettings
            /* 0x84FD */ "HeaderText", // Windows.UI.Xaml.Controls.Primitives.CalendarViewTemplateSettings
            /* 0x84FE */ null,
            /* 0x84FF */ null,
            /* 0x8500 */ "WeekDay1", // Windows.UI.Xaml.Controls.Primitives.CalendarViewTemplateSettings
            /* 0x8501 */ "WeekDay2", // Windows.UI.Xaml.Controls.Primitives.CalendarViewTemplateSettings
            /* 0x8502 */ "WeekDay3", // Windows.UI.Xaml.Controls.Primitives.CalendarViewTemplateSettings
            /* 0x8503 */ "WeekDay4", // Windows.UI.Xaml.Controls.Primitives.CalendarViewTemplateSettings
            /* 0x8504 */ "WeekDay5", // Windows.UI.Xaml.Controls.Primitives.CalendarViewTemplateSettings
            /* 0x8505 */ "WeekDay6", // Windows.UI.Xaml.Controls.Primitives.CalendarViewTemplateSettings
            /* 0x8506 */ "WeekDay7", // Windows.UI.Xaml.Controls.Primitives.CalendarViewTemplateSettings
            /* 0x8507 */ null,
            /* 0x8508 */ null,
            /* 0x8509 */ null,
            /* 0x850A */ null,
            /* 0x850B */ "CalendarIdentifier", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x850C */ null,
            /* 0x850D */ null,
            /* 0x850E */ null,
            /* 0x850F */ null,
            /* 0x8510 */ null,
            /* 0x8511 */ null,
            /* 0x8512 */ null,
            /* 0x8513 */ "DayOfWeekFormat", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8514 */ null,
            /* 0x8515 */ null,
            /* 0x8516 */ "DisplayMode", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8517 */ "FirstDayOfWeek", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8518 */ null,
            /* 0x8519 */ null,
            /* 0x851A */ null,
            /* 0x851B */ null,
            /* 0x851C */ null,
            /* 0x851D */ null,
            /* 0x851E */ null,
            /* 0x851F */ null,
            /* 0x8520 */ null,
            /* 0x8521 */ null,
            /* 0x8522 */ null,
            /* 0x8523 */ null,
            /* 0x8524 */ null,
            /* 0x8525 */ "IsOutOfScopeEnabled", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8526 */ "IsTodayHighlighted", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8527 */ null,
            /* 0x8528 */ "MaxDate", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8529 */ "MinDate", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x852A */ null,
            /* 0x852B */ null,
            /* 0x852C */ null,
            /* 0x852D */ null,
            /* 0x852E */ null,
            /* 0x852F */ "NumberOfWeeksInView", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8530 */ null,
            /* 0x8531 */ null,
            /* 0x8532 */ null,
            /* 0x8533 */ null,
            /* 0x8534 */ null,
            /* 0x8535 */ "SelectedDates", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8536 */ null,
            /* 0x8537 */ "SelectionMode", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8538 */ "TemplateSettings", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8539 */ null,
            /* 0x853A */ null,
            /* 0x853B */ "Date", // Windows.UI.Xaml.Controls.CalendarViewDayItem
            /* 0x853C */ "IsBlackout", // Windows.UI.Xaml.Controls.CalendarViewDayItem
            /* 0x853D */ "Date", // Windows.UI.Xaml.Controls.Primitives.CalendarViewItem
            /* 0x853E */ null,
            /* 0x853F */ null,
            /* 0x8540 */ null,
            /* 0x8541 */ null,
            /* 0x8542 */ null,
            /* 0x8543 */ null,
            /* 0x8544 */ null,
            /* 0x8545 */ null,
            /* 0x8546 */ null,
            /* 0x8547 */ null,
            /* 0x8548 */ null,
            /* 0x8549 */ null,
            /* 0x854A */ null,
            /* 0x854B */ null,
            /* 0x854C */ null,
            /* 0x854D */ null,
            /* 0x854E */ null,
            /* 0x854F */ null,
            /* 0x8550 */ null,
            /* 0x8551 */ null,
            /* 0x8552 */ null,
            /* 0x8553 */ null,
            /* 0x8554 */ null,
            /* 0x8555 */ null,
            /* 0x8556 */ null,
            /* 0x8557 */ null,
            /* 0x8558 */ null,
            /* 0x8559 */ null,
            /* 0x855A */ null,
            /* 0x855B */ null,
            /* 0x855C */ null,
            /* 0x855D */ null,
            /* 0x855E */ null,
            /* 0x855F */ null,
            /* 0x8560 */ null,
            /* 0x8561 */ null,
            /* 0x8562 */ null,
            /* 0x8563 */ null,
            /* 0x8564 */ null,
            /* 0x8565 */ null,
            /* 0x8566 */ "IsFastForwardEnabled", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x8567 */ "IsFastRewindEnabled", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x8568 */ "IsFullWindowEnabled", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x8569 */ "IsPlaybackRateEnabled", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x856A */ "IsSeekEnabled", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x856B */ "IsStopEnabled", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x856C */ "IsVolumeEnabled", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x856D */ "IsZoomEnabled", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x856E */ null,
            /* 0x856F */ "Column", // Windows.UI.Xaml.DependencyObject
            /* 0x8570 */ "Line", // Windows.UI.Xaml.DependencyObject
            /* 0x8571 */ null,
            /* 0x8572 */ null,
            /* 0x8573 */ "OffsetXAnimation", // Windows.UI.Xaml.UIElement
            /* 0x8574 */ "OffsetYAnimation", // Windows.UI.Xaml.UIElement
            /* 0x8575 */ "CenterXAnimation", // Windows.UI.Xaml.Media.CompositeTransform
            /* 0x8576 */ "CenterYAnimation", // Windows.UI.Xaml.Media.CompositeTransform
            /* 0x8577 */ "RotateAnimation", // Windows.UI.Xaml.Media.CompositeTransform
            /* 0x8578 */ "ScaleXAnimation", // Windows.UI.Xaml.Media.CompositeTransform
            /* 0x8579 */ "ScaleYAnimation", // Windows.UI.Xaml.Media.CompositeTransform
            /* 0x857A */ "SkewXAnimation", // Windows.UI.Xaml.Media.CompositeTransform
            /* 0x857B */ "SkewYAnimation", // Windows.UI.Xaml.Media.CompositeTransform
            /* 0x857C */ "TranslateXAnimation", // Windows.UI.Xaml.Media.CompositeTransform
            /* 0x857D */ "TranslateYAnimation", // Windows.UI.Xaml.Media.CompositeTransform
            /* 0x857E */ "AngleAnimation", // Windows.UI.Xaml.Media.RotateTransform
            /* 0x857F */ "CenterXAnimation", // Windows.UI.Xaml.Media.RotateTransform
            /* 0x8580 */ "CenterYAnimation", // Windows.UI.Xaml.Media.RotateTransform
            /* 0x8581 */ "CenterXAnimation", // Windows.UI.Xaml.Media.ScaleTransform
            /* 0x8582 */ "CenterYAnimation", // Windows.UI.Xaml.Media.ScaleTransform
            /* 0x8583 */ "ScaleXAnimation", // Windows.UI.Xaml.Media.ScaleTransform
            /* 0x8584 */ "ScaleYAnimation", // Windows.UI.Xaml.Media.ScaleTransform
            /* 0x8585 */ "AngleXAnimation", // Windows.UI.Xaml.Media.SkewTransform
            /* 0x8586 */ "AngleYAnimation", // Windows.UI.Xaml.Media.SkewTransform
            /* 0x8587 */ "CenterXAnimation", // Windows.UI.Xaml.Media.SkewTransform
            /* 0x8588 */ "CenterYAnimation", // Windows.UI.Xaml.Media.SkewTransform
            /* 0x8589 */ "XAnimation", // Windows.UI.Xaml.Media.TranslateTransform
            /* 0x858A */ "YAnimation", // Windows.UI.Xaml.Media.TranslateTransform
            /* 0x858B */ null,
            /* 0x858C */ null,
            /* 0x858D */ null,
            /* 0x858E */ null,
            /* 0x858F */ null,
            /* 0x8590 */ null,
            /* 0x8591 */ "LineHeight", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x8592 */ "UseOverflowStyle", // Windows.UI.Xaml.Controls.AppBarSeparator
            /* 0x8593 */ "UseOverflowStyle", // Windows.UI.Xaml.Controls.AppBarButton
            /* 0x8594 */ "UseOverflowStyle", // Windows.UI.Xaml.Controls.AppBarToggleButton
            /* 0x8595 */ "CacheLength", // Windows.UI.Xaml.Controls.Primitives.CalendarPanel
            /* 0x8596 */ "Cols", // Windows.UI.Xaml.Controls.Primitives.CalendarPanel
            /* 0x8597 */ "Orientation", // Windows.UI.Xaml.Controls.Primitives.CalendarPanel
            /* 0x8598 */ "Rows", // Windows.UI.Xaml.Controls.Primitives.CalendarPanel
            /* 0x8599 */ "ItemMinHeight", // Windows.UI.Xaml.Controls.Primitives.CalendarPanel
            /* 0x859A */ "ItemMinWidth", // Windows.UI.Xaml.Controls.Primitives.CalendarPanel
            /* 0x859B */ "MinViewWidth", // Windows.UI.Xaml.Controls.Primitives.CalendarViewTemplateSettings
            /* 0x859C */ null,
            /* 0x859D */ null,
            /* 0x859E */ null,
            /* 0x859F */ null,
            /* 0x85A0 */ null,
            /* 0x85A1 */ null,
            /* 0x85A2 */ "OpacityAnimation", // Windows.UI.Xaml.Media.Animation.TransitionTarget
            /* 0x85A3 */ "OpacityAnimation", // Windows.UI.Xaml.UIElement
            /* 0x85A4 */ "CenterOfRotationXAnimation", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x85A5 */ "CenterOfRotationYAnimation", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x85A6 */ "CenterOfRotationZAnimation", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x85A7 */ "GlobalOffsetXAnimation", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x85A8 */ "GlobalOffsetYAnimation", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x85A9 */ "GlobalOffsetZAnimation", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x85AA */ "LocalOffsetXAnimation", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x85AB */ "LocalOffsetYAnimation", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x85AC */ "LocalOffsetZAnimation", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x85AD */ "RotationXAnimation", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x85AE */ "RotationYAnimation", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x85AF */ "RotationZAnimation", // Windows.UI.Xaml.Media.PlaneProjection
            /* 0x85B0 */ null,
            /* 0x85B1 */ "CacheLength", // Windows.UI.Xaml.Controls.TileGrid
            /* 0x85B2 */ "Orientation", // Windows.UI.Xaml.Controls.TileGrid
            /* 0x85B3 */ "SelectedRanges", // Windows.UI.Xaml.Controls.ListViewBase
            /* 0x85B4 */ null,
            /* 0x85B5 */ null,
            /* 0x85B6 */ "CompactPaneGridLength", // Windows.UI.Xaml.Controls.Primitives.SplitViewTemplateSettings
            /* 0x85B7 */ "NegativeOpenPaneLength", // Windows.UI.Xaml.Controls.Primitives.SplitViewTemplateSettings
            /* 0x85B8 */ "NegativeOpenPaneLengthMinusCompactLength", // Windows.UI.Xaml.Controls.Primitives.SplitViewTemplateSettings
            /* 0x85B9 */ "OpenPaneGridLength", // Windows.UI.Xaml.Controls.Primitives.SplitViewTemplateSettings
            /* 0x85BA */ "OpenPaneLengthMinusCompactLength", // Windows.UI.Xaml.Controls.Primitives.SplitViewTemplateSettings
            /* 0x85BB */ "CompactPaneLength", // Windows.UI.Xaml.Controls.SplitView
            /* 0x85BC */ "Content", // Windows.UI.Xaml.Controls.SplitView
            /* 0x85BD */ "DisplayMode", // Windows.UI.Xaml.Controls.SplitView
            /* 0x85BE */ "IsPaneOpen", // Windows.UI.Xaml.Controls.SplitView
            /* 0x85BF */ "OpenPaneLength", // Windows.UI.Xaml.Controls.SplitView
            /* 0x85C0 */ "Pane", // Windows.UI.Xaml.Controls.SplitView
            /* 0x85C1 */ "PanePlacement", // Windows.UI.Xaml.Controls.SplitView
            /* 0x85C2 */ "TemplateSettings", // Windows.UI.Xaml.Controls.SplitView
            /* 0x85C3 */ "Transform3D", // Windows.UI.Xaml.UIElement
            /* 0x85C4 */ "CenterX", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x85C5 */ "CenterXAnimation", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x85C6 */ "CenterY", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x85C7 */ "CenterYAnimation", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x85C8 */ "CenterZ", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x85C9 */ "CenterZAnimation", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x85CA */ "RotationX", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x85CB */ "RotationXAnimation", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x85CC */ "RotationY", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x85CD */ "RotationYAnimation", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x85CE */ "RotationZ", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x85CF */ "RotationZAnimation", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x85D0 */ "ScaleX", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x85D1 */ "ScaleXAnimation", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x85D2 */ "ScaleY", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x85D3 */ "ScaleYAnimation", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x85D4 */ "ScaleZ", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x85D5 */ "ScaleZAnimation", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x85D6 */ "TranslateX", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x85D7 */ "TranslateXAnimation", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x85D8 */ "TranslateY", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x85D9 */ "TranslateYAnimation", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x85DA */ "TranslateZ", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x85DB */ "TranslateZAnimation", // Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
            /* 0x85DC */ "Depth", // Windows.UI.Xaml.Media.Media3D.PerspectiveTransform3D
            /* 0x85DD */ "OffsetX", // Windows.UI.Xaml.Media.Media3D.PerspectiveTransform3D
            /* 0x85DE */ "OffsetY", // Windows.UI.Xaml.Media.Media3D.PerspectiveTransform3D
            /* 0x85DF */ "ColorAAnimation", // Windows.UI.Xaml.Media.SolidColorBrush
            /* 0x85E0 */ "ColorBAnimation", // Windows.UI.Xaml.Media.SolidColorBrush
            /* 0x85E1 */ "ColorGAnimation", // Windows.UI.Xaml.Media.SolidColorBrush
            /* 0x85E2 */ "ColorRAnimation", // Windows.UI.Xaml.Media.SolidColorBrush
            /* 0x85E3 */ "ParseUri", // Windows.UI.Xaml.DependencyObject
            /* 0x85E4 */ "Above", // Windows.UI.Xaml.Controls.RelativePanel
            /* 0x85E5 */ "AlignBottomWith", // Windows.UI.Xaml.Controls.RelativePanel
            /* 0x85E6 */ "AlignLeftWith", // Windows.UI.Xaml.Controls.RelativePanel
            /* 0x85E7 */ null,
            /* 0x85E8 */ null,
            /* 0x85E9 */ null,
            /* 0x85EA */ null,
            /* 0x85EB */ "AlignRightWith", // Windows.UI.Xaml.Controls.RelativePanel
            /* 0x85EC */ "AlignTopWith", // Windows.UI.Xaml.Controls.RelativePanel
            /* 0x85ED */ "Below", // Windows.UI.Xaml.Controls.RelativePanel
            /* 0x85EE */ null,
            /* 0x85EF */ null,
            /* 0x85F0 */ "LeftOf", // Windows.UI.Xaml.Controls.RelativePanel
            /* 0x85F1 */ "RightOf", // Windows.UI.Xaml.Controls.RelativePanel
            /* 0x85F2 */ null,
            /* 0x85F3 */ null,
            /* 0x85F4 */ "OpenPaneLength", // Windows.UI.Xaml.Controls.Primitives.SplitViewTemplateSettings
            /* 0x85F5 */ "TransparentBackground", // Windows.UI.Xaml.Window
            /* 0x85F6 */ "AreStickyGroupHeadersEnabledBase", // Windows.UI.Xaml.Controls.ModernCollectionBasePanel
            /* 0x85F7 */ "PasswordRevealMode", // Windows.UI.Xaml.Controls.PasswordBox
            /* 0x85F8 */ "PaneBackground", // Windows.UI.Xaml.Controls.SplitView
            /* 0x85F9 */ "AreStickyGroupHeadersEnabled", // Windows.UI.Xaml.Controls.ItemsStackPanel
            /* 0x85FA */ "AreStickyGroupHeadersEnabled", // Windows.UI.Xaml.Controls.ItemsWrapGrid
            /* 0x85FB */ "Items", // Windows.UI.Xaml.Controls.MenuFlyoutSubItem
            /* 0x85FC */ "Text", // Windows.UI.Xaml.Controls.MenuFlyoutSubItem
            /* 0x85FD */ "XbfHash", // Windows.UI.Xaml.DependencyObject
            /* 0x85FE */ "CanDrag", // Windows.UI.Xaml.UIElement
            /* 0x85FF */ "ExtensionInstance", // Windows.UI.Xaml.DataTemplate
            /* 0x8600 */ null,
            /* 0x8601 */ null,
            /* 0x8602 */ null,
            /* 0x8603 */ null,
            /* 0x8604 */ null,
            /* 0x8605 */ null,
            /* 0x8606 */ null,
            /* 0x8607 */ null,
            /* 0x8608 */ null,
            /* 0x8609 */ null,
            /* 0x860A */ null,
            /* 0x860B */ null,
            /* 0x860C */ null,
            /* 0x860D */ null,
            /* 0x860E */ null,
            /* 0x860F */ null,
            /* 0x8610 */ "AlignHorizontalCenterWith", // Windows.UI.Xaml.Controls.RelativePanel
            /* 0x8611 */ "AlignVerticalCenterWith", // Windows.UI.Xaml.Controls.RelativePanel
            /* 0x8612 */ null,
            /* 0x8613 */ "Path", // Windows.UI.Xaml.TargetPropertyPath
            /* 0x8614 */ "Target", // Windows.UI.Xaml.TargetPropertyPath
            /* 0x8615 */ "__DeferredSetters", // Windows.UI.Xaml.VisualState
            /* 0x8616 */ "Setters", // Windows.UI.Xaml.VisualState
            /* 0x8617 */ "StateTriggers", // Windows.UI.Xaml.VisualState
            /* 0x8618 */ "MinWindowHeight", // Windows.UI.Xaml.AdaptiveTrigger
            /* 0x8619 */ "MinWindowWidth", // Windows.UI.Xaml.AdaptiveTrigger
            /* 0x861A */ "Target", // Windows.UI.Xaml.Setter
            /* 0x861B */ "ContentProperty", // Windows.UI.Xaml.Internal.StateTriggerCollection
            /* 0x861C */ null,
            /* 0x861D */ "BlackoutForeground", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x861E */ "CalendarItemBackground", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x861F */ "CalendarItemBorderBrush", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8620 */ "CalendarItemBorderThickness", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8621 */ "CalendarItemForeground", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8622 */ "CalendarViewDayItemStyle", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8623 */ "DayItemFontFamily", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8624 */ "DayItemFontSize", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8625 */ "DayItemFontStyle", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8626 */ "DayItemFontWeight", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8627 */ "FirstOfMonthLabelFontFamily", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8628 */ "FirstOfMonthLabelFontSize", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8629 */ "FirstOfMonthLabelFontStyle", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x862A */ "FirstOfMonthLabelFontWeight", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x862B */ "FirstOfYearDecadeLabelFontFamily", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x862C */ "FirstOfYearDecadeLabelFontSize", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x862D */ "FirstOfYearDecadeLabelFontStyle", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x862E */ "FirstOfYearDecadeLabelFontWeight", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x862F */ "FocusBorderBrush", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8630 */ "HorizontalDayItemAlignment", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8631 */ "HorizontalFirstOfMonthLabelAlignment", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8632 */ "HoverBorderBrush", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8633 */ null,
            /* 0x8634 */ "MonthYearItemFontFamily", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8635 */ "MonthYearItemFontSize", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8636 */ "MonthYearItemFontStyle", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8637 */ "MonthYearItemFontWeight", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8638 */ "OutOfScopeBackground", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8639 */ "OutOfScopeForeground", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x863A */ "PressedBorderBrush", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x863B */ "PressedForeground", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x863C */ "SelectedBorderBrush", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x863D */ "SelectedForeground", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x863E */ "SelectedHoverBorderBrush", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x863F */ "SelectedPressedBorderBrush", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8640 */ "TodayFontWeight", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8641 */ "TodayForeground", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8642 */ "VerticalDayItemAlignment", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8643 */ "VerticalFirstOfMonthLabelAlignment", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8644 */ null,
            /* 0x8645 */ "IsCompact", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x8646 */ "AlignBottomWithPanel", // Windows.UI.Xaml.Controls.RelativePanel
            /* 0x8647 */ "AlignHorizontalCenterWithPanel", // Windows.UI.Xaml.Controls.RelativePanel
            /* 0x8648 */ "AlignLeftWithPanel", // Windows.UI.Xaml.Controls.RelativePanel
            /* 0x8649 */ "AlignRightWithPanel", // Windows.UI.Xaml.Controls.RelativePanel
            /* 0x864A */ "AlignTopWithPanel", // Windows.UI.Xaml.Controls.RelativePanel
            /* 0x864B */ "AlignVerticalCenterWithPanel", // Windows.UI.Xaml.Controls.RelativePanel
            /* 0x864C */ "IsMultiSelectCheckBoxEnabled", // Windows.UI.Xaml.Controls.ListViewBase
            /* 0x864D */ "IsDraggable", // Windows.UI.Xaml.Controls.ListViewBaseItem
            /* 0x864E */ "Level", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x864F */ "PositionInSet", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x8650 */ "SizeOfSet", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x8651 */ "CheckBoxBrush", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x8652 */ "CheckMode", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x8653 */ null,
            /* 0x8654 */ "PressedBackground", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x8655 */ "SelectedPressedBackground", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x8656 */ "FocusTargetDescendant", // Windows.UI.Xaml.Controls.Control
            /* 0x8657 */ "IsTemplateFocusTarget", // Windows.UI.Xaml.Controls.Control
            /* 0x8658 */ "UseSystemFocusVisuals", // Windows.UI.Xaml.Controls.Control
            /* 0x8659 */ null,
            /* 0x865A */ null,
            /* 0x865B */ "DirectManipulationContainer", // Windows.UI.Xaml.UIElement
            /* 0x865C */ "FocusSecondaryBorderBrush", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x865D */ null,
            /* 0x865E */ "PointerOverForeground", // Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
            /* 0x865F */ "MirroredWhenRightToLeft", // Windows.UI.Xaml.Controls.FontIcon
            /* 0x8660 */ "CenterX", // Windows.UI.Xaml.Controls.Primitives.CalendarViewTemplateSettings
            /* 0x8661 */ "CenterY", // Windows.UI.Xaml.Controls.Primitives.CalendarViewTemplateSettings
            /* 0x8662 */ "ClipRect", // Windows.UI.Xaml.Controls.Primitives.CalendarViewTemplateSettings
            /* 0x8663 */ "HandOffCompositionVisual", // Windows.UI.Xaml.UIElement
            /* 0x8664 */ "DeferredStorage", // Windows.UI.Xaml.DependencyObject
            /* 0x8665 */ "RealizingProxy", // Windows.UI.Xaml.DependencyObject
            /* 0x8666 */ "CanvasOffset", // Windows.UI.Xaml.UIElement
            /* 0x8667 */ null,
            /* 0x8668 */ null,
            /* 0x8669 */ null,
            /* 0x866A */ null,
            /* 0x866B */ null,
            /* 0x866C */ "ClosedRatio", // Windows.UI.Xaml.Media.Animation.MenuPopupThemeTransition
            /* 0x866D */ "Direction", // Windows.UI.Xaml.Media.Animation.MenuPopupThemeTransition
            /* 0x866E */ "OpenedLength", // Windows.UI.Xaml.Media.Animation.MenuPopupThemeTransition
            /* 0x866F */ "DeferredStateTriggers", // Windows.UI.Xaml.Internal.VisualStateGroupCollection
            /* 0x8670 */ "TriggerState", // Windows.UI.Xaml.StateTriggerBase
            /* 0x8671 */ null,
            /* 0x8672 */ "TextReadingOrder", // Windows.UI.Xaml.Controls.PasswordBox
            /* 0x8673 */ "TextReadingOrder", // Windows.UI.Xaml.Controls.RichEditBox
            /* 0x8674 */ "TextReadingOrder", // Windows.UI.Xaml.Controls.TextBox
            /* 0x8675 */ "ExecutionMode", // Windows.UI.Xaml.Controls.WebView
            /* 0x8676 */ "CachedStyleSetterProperty", // Windows.UI.Xaml.TargetPropertyPath
            /* 0x8677 */ "DeferredPermissionRequests", // Windows.UI.Xaml.Controls.WebView
            /* 0x8678 */ "Settings", // Windows.UI.Xaml.Controls.WebView
            /* 0x8679 */ "OffsetFromCenter", // Windows.UI.Xaml.Media.Animation.PickerFlyoutThemeTransition
            /* 0x867A */ "OpenedLength", // Windows.UI.Xaml.Media.Animation.PickerFlyoutThemeTransition
            /* 0x867B */ null,
            /* 0x867C */ "DesiredCandidateWindowAlignment", // Windows.UI.Xaml.Controls.RichEditBox
            /* 0x867D */ null,
            /* 0x867E */ "DesiredCandidateWindowAlignment", // Windows.UI.Xaml.Controls.TextBox
            /* 0x867F */ "CalendarIdentifier", // Windows.UI.Xaml.Controls.CalendarDatePicker
            /* 0x8680 */ "CalendarViewStyle", // Windows.UI.Xaml.Controls.CalendarDatePicker
            /* 0x8681 */ "Date", // Windows.UI.Xaml.Controls.CalendarDatePicker
            /* 0x8682 */ "DateFormat", // Windows.UI.Xaml.Controls.CalendarDatePicker
            /* 0x8683 */ "DayOfWeekFormat", // Windows.UI.Xaml.Controls.CalendarDatePicker
            /* 0x8684 */ "DisplayMode", // Windows.UI.Xaml.Controls.CalendarDatePicker
            /* 0x8685 */ "FirstDayOfWeek", // Windows.UI.Xaml.Controls.CalendarDatePicker
            /* 0x8686 */ "Header", // Windows.UI.Xaml.Controls.CalendarDatePicker
            /* 0x8687 */ "HeaderTemplate", // Windows.UI.Xaml.Controls.CalendarDatePicker
            /* 0x8688 */ "IsCalendarOpen", // Windows.UI.Xaml.Controls.CalendarDatePicker
            /* 0x8689 */ "IsGroupLabelVisible", // Windows.UI.Xaml.Controls.CalendarDatePicker
            /* 0x868A */ "IsOutOfScopeEnabled", // Windows.UI.Xaml.Controls.CalendarDatePicker
            /* 0x868B */ "IsTodayHighlighted", // Windows.UI.Xaml.Controls.CalendarDatePicker
            /* 0x868C */ "MaxDate", // Windows.UI.Xaml.Controls.CalendarDatePicker
            /* 0x868D */ "MinDate", // Windows.UI.Xaml.Controls.CalendarDatePicker
            /* 0x868E */ "PlaceholderText", // Windows.UI.Xaml.Controls.CalendarDatePicker
            /* 0x868F */ "IsGroupLabelVisible", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x8690 */ "Background", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x8691 */ "BorderBrush", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x8692 */ "BorderThickness", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x8693 */ "CornerRadius", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x8694 */ "Padding", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x8695 */ "BorderBrush", // Windows.UI.Xaml.Controls.Grid
            /* 0x8696 */ "BorderThickness", // Windows.UI.Xaml.Controls.Grid
            /* 0x8697 */ "CornerRadius", // Windows.UI.Xaml.Controls.Grid
            /* 0x8698 */ "Padding", // Windows.UI.Xaml.Controls.Grid
            /* 0x8699 */ "BorderBrush", // Windows.UI.Xaml.Controls.RelativePanel
            /* 0x869A */ "BorderThickness", // Windows.UI.Xaml.Controls.RelativePanel
            /* 0x869B */ "CornerRadius", // Windows.UI.Xaml.Controls.RelativePanel
            /* 0x869C */ "Padding", // Windows.UI.Xaml.Controls.RelativePanel
            /* 0x869D */ "BorderBrush", // Windows.UI.Xaml.Controls.StackPanel
            /* 0x869E */ "BorderThickness", // Windows.UI.Xaml.Controls.StackPanel
            /* 0x869F */ "CornerRadius", // Windows.UI.Xaml.Controls.StackPanel
            /* 0x86A0 */ "Padding", // Windows.UI.Xaml.Controls.StackPanel
            /* 0x86A1 */ "InputScope", // Windows.UI.Xaml.Controls.PasswordBox
            /* 0x86A2 */ "DropoutOrder", // Windows.UI.Xaml.Controls.MediaTransportControlsHelper
            /* 0x86A3 */ "ChosenSuggestion", // Windows.UI.Xaml.Controls.AutoSuggestBoxQuerySubmittedEventArgs
            /* 0x86A4 */ "QueryText", // Windows.UI.Xaml.Controls.AutoSuggestBoxQuerySubmittedEventArgs
            /* 0x86A5 */ "QueryIcon", // Windows.UI.Xaml.Controls.AutoSuggestBox
            /* 0x86A6 */ "IsActive", // Windows.UI.Xaml.StateTrigger
            /* 0x86A7 */ "HorizontalContentAlignment", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x86A8 */ "VerticalContentAlignment", // Windows.UI.Xaml.Controls.ContentPresenter
            /* 0x86A9 */ "ClipRect", // Windows.UI.Xaml.Controls.Primitives.AppBarTemplateSettings
            /* 0x86AA */ "CompactRootMargin", // Windows.UI.Xaml.Controls.Primitives.AppBarTemplateSettings
            /* 0x86AB */ "CompactVerticalDelta", // Windows.UI.Xaml.Controls.Primitives.AppBarTemplateSettings
            /* 0x86AC */ "HiddenRootMargin", // Windows.UI.Xaml.Controls.Primitives.AppBarTemplateSettings
            /* 0x86AD */ "HiddenVerticalDelta", // Windows.UI.Xaml.Controls.Primitives.AppBarTemplateSettings
            /* 0x86AE */ "MinimalRootMargin", // Windows.UI.Xaml.Controls.Primitives.AppBarTemplateSettings
            /* 0x86AF */ "MinimalVerticalDelta", // Windows.UI.Xaml.Controls.Primitives.AppBarTemplateSettings
            /* 0x86B0 */ "ContentHeight", // Windows.UI.Xaml.Controls.Primitives.CommandBarTemplateSettings
            /* 0x86B1 */ "NegativeOverflowContentHeight", // Windows.UI.Xaml.Controls.Primitives.CommandBarTemplateSettings
            /* 0x86B2 */ "OverflowContentClipRect", // Windows.UI.Xaml.Controls.Primitives.CommandBarTemplateSettings
            /* 0x86B3 */ "OverflowContentHeight", // Windows.UI.Xaml.Controls.Primitives.CommandBarTemplateSettings
            /* 0x86B4 */ "OverflowContentHorizontalOffset", // Windows.UI.Xaml.Controls.Primitives.CommandBarTemplateSettings
            /* 0x86B5 */ "OverflowContentMaxHeight", // Windows.UI.Xaml.Controls.Primitives.CommandBarTemplateSettings
            /* 0x86B6 */ "OverflowContentMinWidth", // Windows.UI.Xaml.Controls.Primitives.CommandBarTemplateSettings
            /* 0x86B7 */ "TemplateSettings", // Windows.UI.Xaml.Controls.AppBar
            /* 0x86B8 */ "CommandBarOverflowPresenterStyle", // Windows.UI.Xaml.Controls.CommandBar
            /* 0x86B9 */ "CommandBarTemplateSettings", // Windows.UI.Xaml.Controls.CommandBar
            /* 0x86BA */ "EntranceTarget", // Windows.UI.Xaml.Media.Animation.DrillInThemeAnimation
            /* 0x86BB */ "EntranceTargetName", // Windows.UI.Xaml.Media.Animation.DrillInThemeAnimation
            /* 0x86BC */ "ExitTarget", // Windows.UI.Xaml.Media.Animation.DrillInThemeAnimation
            /* 0x86BD */ "ExitTargetName", // Windows.UI.Xaml.Media.Animation.DrillInThemeAnimation
            /* 0x86BE */ "EntranceTarget", // Windows.UI.Xaml.Media.Animation.DrillOutThemeAnimation
            /* 0x86BF */ "EntranceTargetName", // Windows.UI.Xaml.Media.Animation.DrillOutThemeAnimation
            /* 0x86C0 */ "ExitTarget", // Windows.UI.Xaml.Media.Animation.DrillOutThemeAnimation
            /* 0x86C1 */ "ExitTargetName", // Windows.UI.Xaml.Media.Animation.DrillOutThemeAnimation
            /* 0x86C2 */ "DataTemplateComponent", // Windows.UI.Xaml.Markup.XamlBindingHelper
            /* 0x86C3 */ "DeferredSetters", // Windows.UI.Xaml.Internal.VisualStateGroupCollection
            /* 0x86C4 */ "Annotations", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x86C5 */ "Element", // Windows.UI.Xaml.Automation.AutomationAnnotation
            /* 0x86C6 */ "Type", // Windows.UI.Xaml.Automation.AutomationAnnotation
            /* 0x86C7 */ "Peer", // Windows.UI.Xaml.Automation.Peers.AutomationPeerAnnotation
            /* 0x86C8 */ "Type", // Windows.UI.Xaml.Automation.Peers.AutomationPeerAnnotation
            /* 0x86C9 */ "ContentProperty", // Windows.UI.Xaml.Automation.AutomationAnnotationCollection
            /* 0x86CA */ "ContentProperty", // Windows.UI.Xaml.Automation.Peers.AutomationPeerAnnotationCollection
            /* 0x86CB */ "StartIndex", // Windows.UI.Xaml.Controls.Primitives.CalendarPanel
            /* 0x86CC */ "AutomationPeerFactoryIndex", // Windows.UI.Xaml.FrameworkElement
            /* 0x86CD */ "UnderlineStyle", // Windows.UI.Xaml.Documents.Hyperlink
            /* 0x86CE */ "DisabledForeground", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x86CF */ "TodayBackground", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x86D0 */ "TodayBlackoutBackground", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x86D1 */ "TodayHoverBorderBrush", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x86D2 */ "TodayPressedBorderBrush", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x86D3 */ "TodaySelectedInnerBorderBrush", // Windows.UI.Xaml.Controls.CalendarView
            /* 0x86D4 */ "IsContentDialog", // Windows.UI.Xaml.Controls.Primitives.Popup
            /* 0x86D5 */ "IsFocusEngaged", // Windows.UI.Xaml.Controls.Control
            /* 0x86D6 */ null,
            /* 0x86D7 */ "ElevatorHelper", // Windows.UI.Xaml.Controls.Control
            /* 0x86D8 */ "IsFocusEngagementEnabled", // Windows.UI.Xaml.Controls.Control
            /* 0x86D9 */ "LayoutToWindowBounds", // Windows.UI.Xaml.Controls.Page
            /* 0x86DA */ "ClipboardCopyFormat", // Windows.UI.Xaml.Controls.RichEditBox
            /* 0x86DB */ "PreventEditFocusLoss", // Windows.UI.Xaml.Controls.TextBox
            /* 0x86DC */ "HandInCompositionVisual", // Windows.UI.Xaml.UIElement
            /* 0x86DD */ "OverflowContentMaxWidth", // Windows.UI.Xaml.Controls.Primitives.CommandBarTemplateSettings
            /* 0x86DE */ "DropDownContentMinWidth", // Windows.UI.Xaml.Controls.Primitives.ComboBoxTemplateSettings
            /* 0x86DF */ null,
            /* 0x86E0 */ null,
            /* 0x86E1 */ "HandOffVisualTransform", // Windows.UI.Xaml.UIElement
            /* 0x86E2 */ "FlyoutContentMinWidth", // Windows.UI.Xaml.Controls.Primitives.MenuFlyoutPresenterTemplateSettings
            /* 0x86E3 */ "TemplateSettings", // Windows.UI.Xaml.Controls.MenuFlyoutPresenter
            /* 0x86E4 */ null,
            /* 0x86E5 */ null,
            /* 0x86E6 */ "LandmarkType", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x86E7 */ "LocalizedLandmarkType", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x86E8 */ "GlobalScaleFactor", // Windows.UI.Xaml.UIElement
            /* 0x86E9 */ "IsStaggeringEnabled", // Windows.UI.Xaml.Media.Animation.RepositionThemeTransition
            /* 0x86EA */ "SingleSelectionFollowsFocus", // Windows.UI.Xaml.Controls.ListBox
            /* 0x86EB */ "SingleSelectionFollowsFocus", // Windows.UI.Xaml.Controls.ListViewBase
            /* 0x86EC */ "AssociatedFlyout", // Windows.UI.Xaml.Controls.Primitives.Popup
            /* 0x86ED */ "AutoPlay", // Windows.UI.Xaml.Media.Imaging.BitmapImage
            /* 0x86EE */ "IsAnimatedBitmap", // Windows.UI.Xaml.Media.Imaging.BitmapImage
            /* 0x86EF */ "IsPlaying", // Windows.UI.Xaml.Media.Imaging.BitmapImage
            /* 0x86F0 */ "FullDescription", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x86F1 */ "IsDataValidForForm", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x86F2 */ "IsPeripheral", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x86F3 */ "LocalizedControlType", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x86F4 */ "AllowFocusOnInteraction", // Windows.UI.Xaml.Controls.Primitives.FlyoutBase
            /* 0x86F5 */ "AllowFocusOnInteraction", // Windows.UI.Xaml.Documents.TextElement
            /* 0x86F6 */ "AllowFocusOnInteraction", // Windows.UI.Xaml.FrameworkElement
            /* 0x86F7 */ "RequiresPointer", // Windows.UI.Xaml.Controls.Control
            /* 0x86F8 */ null,
            /* 0x86F9 */ "ContextFlyout", // Windows.UI.Xaml.UIElement
            /* 0x86FA */ "AccessKey", // Windows.UI.Xaml.Documents.TextElement
            /* 0x86FB */ "AccessKeyScopeOwner", // Windows.UI.Xaml.UIElement
            /* 0x86FC */ "IsAccessKeyScope", // Windows.UI.Xaml.UIElement
            /* 0x86FD */ null,
            /* 0x86FE */ "DescribedBy", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x86FF */ null,
            /* 0x8700 */ null,
            /* 0x8701 */ null,
            /* 0x8702 */ null,
            /* 0x8703 */ null,
            /* 0x8704 */ null,
            /* 0x8705 */ null,
            /* 0x8706 */ null,
            /* 0x8707 */ null,
            /* 0x8708 */ null,
            /* 0x8709 */ null,
            /* 0x870A */ null,
            /* 0x870B */ "AccessKey", // Windows.UI.Xaml.UIElement
            /* 0x870C */ "XYFocusDown", // Windows.UI.Xaml.Controls.Control
            /* 0x870D */ "XYFocusLeft", // Windows.UI.Xaml.Controls.Control
            /* 0x870E */ "XYFocusRight", // Windows.UI.Xaml.Controls.Control
            /* 0x870F */ "XYFocusUp", // Windows.UI.Xaml.Controls.Control
            /* 0x8710 */ "XYFocusDown", // Windows.UI.Xaml.Documents.Hyperlink
            /* 0x8711 */ "XYFocusLeft", // Windows.UI.Xaml.Documents.Hyperlink
            /* 0x8712 */ "XYFocusRight", // Windows.UI.Xaml.Documents.Hyperlink
            /* 0x8713 */ "XYFocusUp", // Windows.UI.Xaml.Documents.Hyperlink
            /* 0x8714 */ "XYFocusDown", // Windows.UI.Xaml.Controls.WebView
            /* 0x8715 */ "XYFocusLeft", // Windows.UI.Xaml.Controls.WebView
            /* 0x8716 */ "XYFocusRight", // Windows.UI.Xaml.Controls.WebView
            /* 0x8717 */ "XYFocusUp", // Windows.UI.Xaml.Controls.WebView
            /* 0x8718 */ "EffectiveOverflowButtonVisibility", // Windows.UI.Xaml.Controls.Primitives.CommandBarTemplateSettings
            /* 0x8719 */ "IsInOverflow", // Windows.UI.Xaml.Controls.AppBarSeparator
            /* 0x871A */ "DefaultLabelPosition", // Windows.UI.Xaml.Controls.CommandBar
            /* 0x871B */ "IsDynamicOverflowEnabled", // Windows.UI.Xaml.Controls.CommandBar
            /* 0x871C */ "OverflowButtonVisibility", // Windows.UI.Xaml.Controls.CommandBar
            /* 0x871D */ "IsInOverflow", // Windows.UI.Xaml.Controls.AppBarButton
            /* 0x871E */ "LabelPosition", // Windows.UI.Xaml.Controls.AppBarButton
            /* 0x871F */ "IsInOverflow", // Windows.UI.Xaml.Controls.AppBarToggleButton
            /* 0x8720 */ "LabelPosition", // Windows.UI.Xaml.Controls.AppBarToggleButton
            /* 0x8721 */ "LightDismissOverlayMode", // Windows.UI.Xaml.Controls.Primitives.FlyoutBase
            /* 0x8722 */ "DisableOverlayIsLightDismissCheck", // Windows.UI.Xaml.Controls.Primitives.Popup
            /* 0x8723 */ "LightDismissOverlayMode", // Windows.UI.Xaml.Controls.Primitives.Popup
            /* 0x8724 */ "OverlayElement", // Windows.UI.Xaml.Controls.Primitives.Popup
            /* 0x8725 */ "LightDismissOverlayMode", // Windows.UI.Xaml.Controls.CalendarDatePicker
            /* 0x8726 */ "LightDismissOverlayMode", // Windows.UI.Xaml.Controls.DatePicker
            /* 0x8727 */ "LightDismissOverlayMode", // Windows.UI.Xaml.Controls.SplitView
            /* 0x8728 */ "LightDismissOverlayMode", // Windows.UI.Xaml.Controls.TimePicker
            /* 0x8729 */ "LightDismissOverlayMode", // Windows.UI.Xaml.Controls.AppBar
            /* 0x872A */ "LightDismissOverlayMode", // Windows.UI.Xaml.Controls.AutoSuggestBox
            /* 0x872B */ "LightDismissOverlayMode", // Windows.UI.Xaml.Controls.ComboBox
            /* 0x872C */ "DynamicOverflowOrder", // Windows.UI.Xaml.Controls.AppBarSeparator
            /* 0x872D */ "DynamicOverflowOrder", // Windows.UI.Xaml.Controls.AppBarButton
            /* 0x872E */ "DynamicOverflowOrder", // Windows.UI.Xaml.Controls.AppBarToggleButton
            /* 0x872F */ "FocusVisualMargin", // Windows.UI.Xaml.FrameworkElement
            /* 0x8730 */ "FocusVisualPrimaryBrush", // Windows.UI.Xaml.FrameworkElement
            /* 0x8731 */ "FocusVisualPrimaryThickness", // Windows.UI.Xaml.FrameworkElement
            /* 0x8732 */ "FocusVisualSecondaryBrush", // Windows.UI.Xaml.FrameworkElement
            /* 0x8733 */ "FocusVisualSecondaryThickness", // Windows.UI.Xaml.FrameworkElement
            /* 0x8734 */ null,
            /* 0x8735 */ null,
            /* 0x8736 */ "AllowFocusWhenDisabled", // Windows.UI.Xaml.Controls.Primitives.FlyoutBase
            /* 0x8737 */ "AllowFocusWhenDisabled", // Windows.UI.Xaml.FrameworkElement
            /* 0x8738 */ "IsTextSearchEnabled", // Windows.UI.Xaml.Controls.ComboBox
            /* 0x8739 */ "ExitDisplayModeOnAccessKeyInvoked", // Windows.UI.Xaml.Documents.TextElement
            /* 0x873A */ "ExitDisplayModeOnAccessKeyInvoked", // Windows.UI.Xaml.UIElement
            /* 0x873B */ "IsFullWindow", // Windows.UI.Xaml.Controls.MediaPlayerPresenter
            /* 0x873C */ "MediaPlayer", // Windows.UI.Xaml.Controls.MediaPlayerPresenter
            /* 0x873D */ "Stretch", // Windows.UI.Xaml.Controls.MediaPlayerPresenter
            /* 0x873E */ "AreTransportControlsEnabled", // Windows.UI.Xaml.Controls.MediaPlayerElement
            /* 0x873F */ "AutoPlay", // Windows.UI.Xaml.Controls.MediaPlayerElement
            /* 0x8740 */ "IsFullWindow", // Windows.UI.Xaml.Controls.MediaPlayerElement
            /* 0x8741 */ "MediaPlayer", // Windows.UI.Xaml.Controls.MediaPlayerElement
            /* 0x8742 */ "PosterSource", // Windows.UI.Xaml.Controls.MediaPlayerElement
            /* 0x8743 */ "Source", // Windows.UI.Xaml.Controls.MediaPlayerElement
            /* 0x8744 */ "Stretch", // Windows.UI.Xaml.Controls.MediaPlayerElement
            /* 0x8745 */ "TransportControls", // Windows.UI.Xaml.Controls.MediaPlayerElement
            /* 0x8746 */ "FastPlayFallbackBehaviour", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x8747 */ "IsNextTrackButtonVisible", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x8748 */ "IsPreviousTrackButtonVisible", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x8749 */ "IsSkipBackwardButtonVisible", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x874A */ "IsSkipBackwardEnabled", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x874B */ "IsSkipForwardButtonVisible", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x874C */ "IsSkipForwardEnabled", // Windows.UI.Xaml.Controls.MediaTransportControls
            /* 0x874D */ "ElementSoundMode", // Windows.UI.Xaml.Controls.Primitives.FlyoutBase
            /* 0x874E */ "ElementSoundMode", // Windows.UI.Xaml.Controls.Control
            /* 0x874F */ "ElementSoundMode", // Windows.UI.Xaml.Documents.Hyperlink
            /* 0x8750 */ "OpacityExpression", // Windows.UI.Xaml.UIElement
            /* 0x8751 */ "IsGamepadFocusCandidate", // Windows.UI.Xaml.UIElement
            /* 0x8752 */ "IsSubMenu", // Windows.UI.Xaml.Controls.Primitives.Popup
            /* 0x8753 */ "ContentProperty", // Windows.UI.Xaml.Media.BrushCollection
            /* 0x8754 */ "FlowsFrom", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x8755 */ "FlowsTo", // Windows.UI.Xaml.Automation.AutomationProperties
            /* 0x8756 */ "RequiresPointerMode", // Windows.UI.Xaml.Application
        };
    }
}
