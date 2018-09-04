﻿using System;
using System.Linq;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace OneLine {
    internal class SeparatorDrawer {
        private const float width = 8;
        private const float lineWidth = 2;

        public void Draw(SerializedProperty property, Slices slices){
            Slice slice;
            if (property.IsArrayElement()){
                slice = new Slice(0, width, DrawInternal);
            }
            else {
                slice = new Slice(0, width, DrawInternal, DrawInternal);
            }
            slices.Add(slice);
        }


        public void DrawInternal (Rect rect){
            rect.x += (rect.width - lineWidth) / 2;
            rect.width = lineWidth;
            GuiUtil.DrawRect(rect, GuiUtil.GrayColor);
        }

    }
}
