using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace NativeIosLibrary
{
    // @interface MathX : NSObject
    [BaseType(typeof(NSObject))]
    interface MathX
    {
        // +(int)addX:(int)number01 number02:(int)number02;
        [Static]
        [Export("addX:number02:")]
        int AddX(int number01, int number02);

        // +(int)multiplyX:(int)number01 number02:(int)number02;
        [Static]
        [Export("multiplyX:number02:")]
        int MultiplyX(int number01, int number02);

        // +(int)subtractX:(int)number01 number02:(int)number02;
        [Static]
        [Export("subtractX:number02:")]
        int SubtractX(int number01, int number02);
    }

}