#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.BellsTest_Qsharp\",\"Name\":\"Set\"},\"SourceFile\":\"C:/Users/1712082018/Desktop/qsharp/BellsTest/BellsTest_Qsharp/BellsTest_Qsharp/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"sabrina\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":16},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"value\"]},\"Type\":{\"Case\":\"Result\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.BellsTest_Qsharp\",\"Name\":\"Set\"},\"SourceFile\":\"C:/Users/1712082018/Desktop/qsharp/BellsTest/BellsTest_Qsharp/BellsTest_Qsharp/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.BellsTest_Qsharp\",\"Name\":\"Bells\"},\"SourceFile\":\"C:/Users/1712082018/Desktop/qsharp/BellsTest/BellsTest_Qsharp/BellsTest_Qsharp/Operations.qs\",\"Position\":{\"Item1\":12,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"count\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":22}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.BellsTest_Qsharp\",\"Name\":\"Bells\"},\"SourceFile\":\"C:/Users/1712082018/Desktop/qsharp/BellsTest/BellsTest_Qsharp/BellsTest_Qsharp/Operations.qs\",\"Position\":{\"Item1\":12,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.BellsTest_Qsharp
{
    public class Set : Operation<(Qubit,Result), QVoid>, ICallable
    {
        public Set(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Result)>, IApplyData
        {
            public In((Qubit,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                }
            }
        }

        String ICallable.Name => "Set";
        String ICallable.FullName => "Quantum.BellsTest_Qsharp.Set";
        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(Qubit,Result), QVoid> Body => (__in__) =>
        {
            var (sabrina,value) = __in__;
#line 7 "C:\\Users\\1712082018\\Desktop\\qsharp\\BellsTest\\BellsTest_Qsharp\\BellsTest_Qsharp\\Operations.qs"
            var rest = MicrosoftQuantumIntrinsicM.Apply(sabrina);
#line 8 "C:\\Users\\1712082018\\Desktop\\qsharp\\BellsTest\\BellsTest_Qsharp\\BellsTest_Qsharp\\Operations.qs"
            if ((rest != value))
            {
#line 9 "C:\\Users\\1712082018\\Desktop\\qsharp\\BellsTest\\BellsTest_Qsharp\\BellsTest_Qsharp\\Operations.qs"
                MicrosoftQuantumIntrinsicX.Apply(sabrina);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((Qubit,Result) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit sabrina, Result value)
        {
            return __m__.Run<Set, (Qubit,Result), QVoid>((sabrina, value));
        }
    }

    public class Bells : Operation<Int64, (Int64,Int64)>, ICallable
    {
        public Bells(IOperationFactory m) : base(m)
        {
        }

        public class Out : QTuple<(Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Bells";
        String ICallable.FullName => "Quantum.BellsTest_Qsharp.Bells";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Result), QVoid> Set
        {
            get;
            set;
        }

        public override Func<Int64, (Int64,Int64)> Body => (__in__) =>
        {
            var count = __in__;
#line 14 "C:\\Users\\1712082018\\Desktop\\qsharp\\BellsTest\\BellsTest_Qsharp\\BellsTest_Qsharp\\Operations.qs"
            var k = 0L;
#line hidden
            {
#line 16 "C:\\Users\\1712082018\\Desktop\\qsharp\\BellsTest\\BellsTest_Qsharp\\BellsTest_Qsharp\\Operations.qs"
                var sabrina = Allocate.Apply();
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 17 "C:\\Users\\1712082018\\Desktop\\qsharp\\BellsTest\\BellsTest_Qsharp\\BellsTest_Qsharp\\Operations.qs"
                    foreach (var test in new Range(1L, count))
#line hidden
                    {
#line 18 "C:\\Users\\1712082018\\Desktop\\qsharp\\BellsTest\\BellsTest_Qsharp\\BellsTest_Qsharp\\Operations.qs"
                        Set.Apply((sabrina, Result.Zero));
#line 19 "C:\\Users\\1712082018\\Desktop\\qsharp\\BellsTest\\BellsTest_Qsharp\\BellsTest_Qsharp\\Operations.qs"
                        MicrosoftQuantumIntrinsicH.Apply(sabrina);
#line 21 "C:\\Users\\1712082018\\Desktop\\qsharp\\BellsTest\\BellsTest_Qsharp\\BellsTest_Qsharp\\Operations.qs"
                        var medicao = MicrosoftQuantumIntrinsicM.Apply(sabrina);
#line 23 "C:\\Users\\1712082018\\Desktop\\qsharp\\BellsTest\\BellsTest_Qsharp\\BellsTest_Qsharp\\Operations.qs"
                        if ((medicao == Result.One))
                        {
#line 24 "C:\\Users\\1712082018\\Desktop\\qsharp\\BellsTest\\BellsTest_Qsharp\\BellsTest_Qsharp\\Operations.qs"
                            k = (k + 1L);
                        }
                    }

#line 28 "C:\\Users\\1712082018\\Desktop\\qsharp\\BellsTest\\BellsTest_Qsharp\\BellsTest_Qsharp\\Operations.qs"
                    Set.Apply((sabrina, Result.Zero));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(sabrina);
                }
            }

#line 30 "C:\\Users\\1712082018\\Desktop\\qsharp\\BellsTest\\BellsTest_Qsharp\\BellsTest_Qsharp\\Operations.qs"
            return ((count - k), k);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.Set = this.Factory.Get<ICallable<(Qubit,Result), QVoid>>(typeof(Set));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut((Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64)> Run(IOperationFactory __m__, Int64 count)
        {
            return __m__.Run<Bells, Int64, (Int64,Int64)>(count);
        }
    }
}