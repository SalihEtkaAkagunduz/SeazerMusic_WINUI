﻿#pragma checksum "C:\Users\s2344\source\repos\seazer music\seazer music\CustomControls\FooterListView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BDE2A0F6BE999F65D16906201BA3208DC038BFF2F810EAADDA1E0714CD2D78AA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace seazer_music.CustomControls
{
    partial class FooterListView : 
        global::Microsoft.UI.Xaml.Controls.UserControl, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2506")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(global::Microsoft.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_ItemsRepeater_ItemsSource(global::Microsoft.UI.Xaml.Controls.ItemsRepeater obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_Image_Source(global::Microsoft.UI.Xaml.Controls.Image obj, global::Microsoft.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Microsoft.UI.Xaml.Media.ImageSource) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Microsoft.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2506")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private partial class FooterListView_obj9_Bindings :
            global::Microsoft.UI.Xaml.IDataTemplateExtension,
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IFooterListView_Bindings
        {
            private global::seazer_music.Class.FooterList dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj9;
            private global::Microsoft.UI.Xaml.Controls.Image obj20;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj21;
            private global::Microsoft.UI.Xaml.Controls.Image obj22;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj20SourceDisabled = false;
            private static bool isobj21TextDisabled = false;
            private static bool isobj22SourceDisabled = false;

            public FooterListView_obj9_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 98 && columnNumber == 60)
                {
                    isobj20SourceDisabled = true;
                }
                else if (lineNumber == 100 && columnNumber == 83)
                {
                    isobj21TextDisabled = true;
                }
                else if (lineNumber == 89 && columnNumber == 53)
                {
                    isobj22SourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 9: // CustomControls\FooterListView.xaml line 78
                        this.obj9 = new global::System.WeakReference(global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target));
                        break;
                    case 20: // CustomControls\FooterListView.xaml line 95
                        this.obj20 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Image>(target);
                        break;
                    case 21: // CustomControls\FooterListView.xaml line 100
                        this.obj21 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 22: // CustomControls\FooterListView.xaml line 86
                        this.obj22 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Image>(target);
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2506")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
                        }

            public void DataContextChangedHandler(global::Microsoft.UI.Xaml.FrameworkElement sender, global::Microsoft.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Microsoft.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            var rootElement = (this.obj9.Target as global::Microsoft.UI.Xaml.Controls.Grid);
                            if (rootElement != null)
                            {
                                rootElement.DataContextChanged -= this.DataContextChangedHandler;
                            }
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_(global::WinRT.CastExtensions.As<global::seazer_music.Class.FooterList>(item), 1 << phase);
            }

            public void Recycle()
            {
            }

            // IFooterListView_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = global::WinRT.CastExtensions.As<global::seazer_music.Class.FooterList>(newDataRoot);
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::seazer_music.Class.FooterList obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Image(obj.Image, phase);
                        this.Update_Title(obj.Title, phase);
                    }
                }
            }
            private void Update_Image(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // CustomControls\FooterListView.xaml line 95
                    if (!isobj20SourceDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Image_Source(this.obj20, (global::Microsoft.UI.Xaml.Media.ImageSource) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Microsoft.UI.Xaml.Media.ImageSource), obj), null);
                    }
                    // CustomControls\FooterListView.xaml line 86
                    if (!isobj22SourceDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Image_Source(this.obj22, (global::Microsoft.UI.Xaml.Media.ImageSource) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Microsoft.UI.Xaml.Media.ImageSource), obj), null);
                    }
                }
            }
            private void Update_Title(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // CustomControls\FooterListView.xaml line 100
                    if (!isobj21TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj21, obj, null);
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2506")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private partial class FooterListView_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IFooterListView_Bindings
        {
            private global::seazer_music.CustomControls.FooterListView dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj2;
            private global::Microsoft.UI.Xaml.Controls.ItemsRepeater obj7;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2TextDisabled = false;
            private static bool isobj7ItemsSourceDisabled = false;

            private FooterListView_obj1_BindingsTracking bindingsTracking;

            public FooterListView_obj1_Bindings()
            {
                this.bindingsTracking = new FooterListView_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 30 && columnNumber == 13)
                {
                    isobj2TextDisabled = true;
                }
                else if (lineNumber == 75 && columnNumber == 34)
                {
                    isobj7ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // CustomControls\FooterListView.xaml line 25
                        this.obj2 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 7: // CustomControls\FooterListView.xaml line 75
                        this.obj7 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ItemsRepeater>(target);
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2506")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
                        }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IFooterListView_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = global::WinRT.CastExtensions.As<global::seazer_music.CustomControls.FooterListView>(newDataRoot);
                    return true;
                }
                return false;
            }

            public void Activated(object obj, global::Microsoft.UI.Xaml.WindowActivatedEventArgs data)
            {
                this.Initialize();
            }

            public void Loading(global::Microsoft.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::seazer_music.CustomControls.FooterListView obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Title(obj.Title, phase);
                        this.Update_Items(obj.Items, phase);
                    }
                }
            }
            private void Update_Title(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // CustomControls\FooterListView.xaml line 25
                    if (!isobj2TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj2, obj, null);
                    }
                }
            }
            private void Update_Items(global::System.Collections.Generic.IEnumerable<global::seazer_music.Class.FooterList> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // CustomControls\FooterListView.xaml line 75
                    if (!isobj7ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsRepeater_ItemsSource(this.obj7, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2506")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class FooterListView_obj1_BindingsTracking
            {
                private global::System.WeakReference<FooterListView_obj1_Bindings> weakRefToBindingObj; 

                public FooterListView_obj1_BindingsTracking(FooterListView_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<FooterListView_obj1_Bindings>(obj);
                }

                public FooterListView_obj1_Bindings TryGetBindingObject()
                {
                    FooterListView_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void DependencyPropertyChanged_Title(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    FooterListView_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::seazer_music.CustomControls.FooterListView obj = sender as global::seazer_music.CustomControls.FooterListView;
                        if (obj != null)
                        {
                            bindings.Update_Title(obj.Title, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_Items(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    FooterListView_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::seazer_music.CustomControls.FooterListView obj = sender as global::seazer_music.CustomControls.FooterListView;
                        if (obj != null)
                        {
                            bindings.Update_Items(obj.Items, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_Title = 0;
                private long tokenDPC_Items = 0;
                public void UpdateChildListeners_(global::seazer_music.CustomControls.FooterListView obj)
                {
                    FooterListView_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::seazer_music.CustomControls.FooterListView.TitleProperty, tokenDPC_Title);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::seazer_music.CustomControls.FooterListView.ItemsProperty, tokenDPC_Items);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_Title = obj.RegisterPropertyChangedCallback(global::seazer_music.CustomControls.FooterListView.TitleProperty, DependencyPropertyChanged_Title);
                            tokenDPC_Items = obj.RegisterPropertyChangedCallback(global::seazer_music.CustomControls.FooterListView.ItemsProperty, DependencyPropertyChanged_Items);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2506")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 3: // CustomControls\FooterListView.xaml line 32
                {
                    global::Microsoft.UI.Xaml.Controls.Grid element3 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Grid)element3).PointerEntered += this.Grid_PointerEntered;
                    ((global::Microsoft.UI.Xaml.Controls.Grid)element3).PointerExited += this.Grid_PointerExited;
                }
                break;
            case 4: // CustomControls\FooterListView.xaml line 39
                {
                    this.BtnLeft = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.BtnLeft).Click += this.BtnLeft_Click;
                }
                break;
            case 5: // CustomControls\FooterListView.xaml line 59
                {
                    this.CardScrollViewer = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ScrollViewer>(target);
                    ((global::Microsoft.UI.Xaml.Controls.ScrollViewer)this.CardScrollViewer).ViewChanged += this.CardScrollViewer_ViewChanged;
                }
                break;
            case 6: // CustomControls\FooterListView.xaml line 200
                {
                    this.BtnRight = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.BtnRight).Click += this.BtnRight_Click;
                }
                break;
            case 10: // CustomControls\FooterListView.xaml line 105
                {
                    global::Microsoft.UI.Xaml.Controls.Grid element10 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Grid)element10).PointerEntered += this.Item_PointerEntered;
                    ((global::Microsoft.UI.Xaml.Controls.Grid)element10).PointerExited += this.Item_PointerExited;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }


        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2506")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // CustomControls\FooterListView.xaml line 2
                {                    
                    global::Microsoft.UI.Xaml.Controls.UserControl element1 = (global::Microsoft.UI.Xaml.Controls.UserControl)target;
                    FooterListView_obj1_Bindings bindings = new FooterListView_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 9: // CustomControls\FooterListView.xaml line 78
                {                    
                    global::Microsoft.UI.Xaml.Controls.Grid element9 = (global::Microsoft.UI.Xaml.Controls.Grid)target;
                    FooterListView_obj9_Bindings bindings = new FooterListView_obj9_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element9.DataContext);
                    element9.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Microsoft.UI.Xaml.DataTemplate.SetExtensionInstance(element9, bindings);
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element9, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

