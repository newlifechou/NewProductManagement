﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Views;
using PMSClient.Helper;
using PMSClient.View;
using PMSClient.ViewModel;
using PMSClient.Tool;

namespace PMSClient
{
    /// <summary>
    /// 公共辅助类
    /// </summary>
    public static class PMSHelper
    {

        static PMSHelper()
        {
            _currentSession = new LogInformation();
            _currentLog = new LocalLog(_currentSession);

            _mainWindow = (App.Current as App).MainWindow as MainDesktop;

            _desktopViews = new ViewLocator();
            _viewModels = (App.Current as App).FindResource("Locator") as ViewModelLocator;

            _toolViews = new ToolViewLocator();
            _toolViewModels = (App.Current as App).FindResource("ToolLocator") as ToolViewModelLocator;
        }
        public static LogInformation CurrentSession
        {
            get { return _currentSession; }
        }
        public static ILog CurrentLog
        {
            get { return _currentLog; }
        }

        #region 当前用户
        private static LogInformation _currentSession;
        private static ILog _currentLog;
        private static MainDesktop _mainWindow;
        #endregion

        #region 视图和视图模型
        private static ViewLocator _desktopViews;

        private static ViewModelLocator _viewModels;


        private static ToolViewLocator _toolViews;
        private static ToolViewModelLocator _toolViewModels;

        public static MainDesktop MainWindow
        {
            get
            {
                return _mainWindow;
            }
        }

        public static ViewLocator DesktopViews
        {
            get { return _desktopViews; }
        }


        public static ViewModelLocator ViewModels
        {
            get { return _viewModels; }
        }


        public static ToolViewLocator ToolViews
        {
            get { return _toolViews; }
        }
        public static ToolViewModelLocator ToolViewModels
        {
            get
            {
                return _toolViewModels;
            }
        }
        #endregion

        #region 语言
        public static string Language { get; set; } = "zh-cn";
        #endregion
    }
}
