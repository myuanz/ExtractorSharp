﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtractorSharp.Core.Lib;
using ExtractorSharp.Data;

namespace ExtractorSharp.Command.FileCommand {
    class ReplaceGif : IMutipleAciton, ICommandMessage {
        public string Name => "ReplaceFile";

        public bool CanUndo => true;

        public bool IsChanged => true;

        public bool IsFlush => true;

        private Album Target,OldSource,Source;

        private string Path;

        private Sprite[] List;

        public void Action(params Album[] array) {
            foreach (var al in array) {
                al.Replace(Source);
            }
        }

        public void Do(params object[] args) {
            Target = args[0] as Album;
            Path = args[1] as string;
            Source = new Album();
            var array = Bitmaps.ReadGif(Path);
            List = new Sprite[array.Length];
            for (var i = 0; i < array.Length; i++) {
                List[i]= new Sprite(Source);
                List[i].Picture = array[i];
                List[i].UnCanvasImage();
            }
            Source.List.AddRange(List);
            Redo();
        }


        public void Redo() {
            OldSource = new Album();
            OldSource.Replace(Target);
            Target.Replace(Source);
        }
        public void Undo() {
            Target.Replace(OldSource);
        }
    }
}
