using Notepad_miku.Models;
using Notepad_miku.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad_miku.ViewModels
{

    public class MainViewModel
    {
        //保存、加载
        private DocumentModel _document;
        //管理文档和格式样式的用户输入
        public EditorViewModel Editor { get; set; }
        //管理保存和加载文本文件
        public FileViewModel File { get; set; }
        //管理帮助对话框
        public HelpViewModel Help { get; set; }

        public MainViewModel()
        {
            _document = new DocumentModel();
            Help = new HelpViewModel();
            Editor = new EditorViewModel(_document);
            File = new FileViewModel(_document);
        }
    }
}