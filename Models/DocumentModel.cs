﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input.StylusPlugIns;

namespace Notepad_miku.Models
{
    //文档模型
    public class DocumentModel : ObservableObject
    {
        private string _text;
        public string Text
        {
            get { return _text; }
            set { OnPropertyChanged(ref _text, value); }
        }

        private string _filePath;
        public string  FilePath
        {
            get { return _filePath; }
            set { OnPropertyChanged(ref _filePath, value); }
        }

        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { OnPropertyChanged(ref _fileName, value); }
        }

        public bool isEmpty
        {
            get
            {
                if(string.IsNullOrEmpty(FileName) || string.IsNullOrEmpty(FilePath))
                    return true;

                return false;
            }
        }
    }
}