﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using NetCoreCMS.Framework.Modules;
using NetCoreCMS.Framework.Core.Models;
using NetCoreCMS.Framework.Modules.Widgets;

namespace NetCoreCMS.Core.Modules.Media
{
    public class BlogModule : IModule
    {
        List<IWidget> _widgets;
        public BlogModule()
        {
            LoadModuleInfo();
            _widgets = new List<IWidget>();
        }

        public string ModuleId { get; set; }
        public string ModuleTitle { get; set; }
        public string ModuleName { get; set; }
        public bool AntiForgery { get; set; }
        public string Author { get; set; }
        public string Website { get; set; }
        public Version Version { get; set; }
        public Version NetCoreCMSVersion { get; set; }
        public string Description { get; set; }
        public List<string> Dependencies { get; set; }
        public string Category { get; set; }
        public Assembly Assembly { get; set; }
        public string SortName { get; set; }
        public string Path { get; set; }
        public NccModule.NccModuleStatus Status { get; set; }
        public List<IWidget> Widgets { get { return _widgets; } set { _widgets = value; } }

        public bool Activate()
        {
            throw new NotImplementedException();
        }

        public bool Inactivate()
        {
            throw new NotImplementedException();
        }

        public void Init(IServiceCollection services)
        {
            
        }

        public bool Install()
        {
            throw new NotImplementedException();
        }

        public void LoadModuleInfo()
        {
            ModuleName = "NetCoreCMS.Modules.Blog";
            Author = "Xonaki";
            Website = "http://xonaki.com";
            AntiForgery = true;
            Description = "Builtin Content Management System Module.";
            Version = new Version(0, 1, 1);
            NetCoreCMSVersion = new Version(0, 1, 1);
            Dependencies = new List<string>();
            Category = "Core";
        }

        public bool Uninstall()
        {
            throw new NotImplementedException();
        }
    }
}