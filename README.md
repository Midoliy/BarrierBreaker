# BarrierBreaker

## BarrierBreakerとは

BarrierBreakerは、静的型付けをするC#のメリットを破壊(= Break)して、動的プログラミングをサポートする機能を提供するライブラリです。  

## BarrierBreakerの使い方

```cs
/**
 * using static で BarrierBreaker.Dynamics を指定してあげる.
 */
using static BarrierBreaker.Dynamics;
using System;

namespace ConsoleApp
{
    class Foo
    {
        public string Bar => "Bar";
        public string GetName() => "Foo";
    }

    class Program
    {
        static void Main(string[] args)
        {
            /**
             * クラスインスタンスからExpandoObjectを生成可能です.
             * ただし, メソッドは引き継げないので注意が必要です.
             */
            var foo = dyn( new Foo() );
            {
                Console.WriteLine(foo.Bar);             // OK
                //Console.WriteLine(foo.GetName());     // NG: 例外が発生する
            }

            /**
             * 匿名クラスからExpandoObjectを生成可能です.
             */
            var point = dyn( new { X=20.5, Y=12.9 } );
            {
                // プロパティにアクセスすることが可能です.
                Console.WriteLine($"X= {point.X}, Y= {point.Y}");   // OK
            }

            /**
             * タプルからExpandoObjectを生成可能です.
             */
            var tuple = dyn( ("Midoliy", 29) );
            {
                // タプルの要素には, Item1 / Item2 でアクセスすることが可能です.
                Console.WriteLine($"Name= {tuple.Item1}, Age= {tuple.Item2}");   // OK
            }

            /**
             * 名前付きタプルからExpandoObjectを生成可能です.
             */
            var named = dyn( (Name:"Midoliy", Age:29) );
            {
                // 要素の名前情報が消えてしまうため, Item1 / Item2 でアクセスする必要があります.
                //Console.WriteLine($"Name= {tuple.Name}, Age= {tuple.Age}");    // NG
                Console.WriteLine($"Name= {tuple.Item1}, Age= {tuple.Item2}");   // OK
            }

            /**
             * ExpandoObjectのため, メソッドもどきを後付けすることも可能です.
             */
            var human = dyn( new { Name = "Midoliy", Y = 29 } );
            {
                // ラムダ式で簡単に後付けすることができます.
                human.SayHello = (Action)(() => Console.WriteLine($"Hello, I'm {human.Name}."));
                human.SayHello();
            }

            /**
             * 既存のインスタンスをExpandoObjectにする拡張メソッドもあります.
             */
            var hoge = new Foo();
            var h = hoge.ToExpandoObject();
            {
                Console.WriteLine($"{h.Bar}");
            }
        }
    }
}
```