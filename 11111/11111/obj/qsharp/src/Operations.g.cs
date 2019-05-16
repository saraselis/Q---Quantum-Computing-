#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum._11111\",\"Name\":\"Set\"},\"SourceFile\":\"C:/Users/1712082018/Desktop/qsharp/11111/11111/Operations.qs\",\"Position\":{\"Item1\":6,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"sabrina\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":15},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"value\"]},\"Type\":{\"Case\":\"Result\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum._11111\",\"Name\":\"Set\"},\"SourceFile\":\"C:/Users/1712082018/Desktop/qsharp/11111/11111/Operations.qs\",\"Position\":{\"Item1\":6,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum._11111\",\"Name\":\"HelloQ\"},\"SourceFile\":\"C:/Users/1712082018/Desktop/qsharp/11111/11111/Operations.qs\",\"Position\":{\"Item1\":16,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum._11111\",\"Name\":\"HelloQ\"},\"SourceFile\":\"C:/Users/1712082018/Desktop/qsharp/11111/11111/Operations.qs\",\"Position\":{\"Item1\":16,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
#line hidden
namespace Quantum._11111
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
        String ICallable.FullName => "Quantum._11111.Set";
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
#line 8 "C:\\Users\\1712082018\\Desktop\\qsharp\\11111\\11111\\Operations.qs"
            var rest = MicrosoftQuantumIntrinsicM.Apply(sabrina);
#line 10 "C:\\Users\\1712082018\\Desktop\\qsharp\\11111\\11111\\Operations.qs"
            if ((rest != value))
            {
#line 11 "C:\\Users\\1712082018\\Desktop\\qsharp\\11111\\11111\\Operations.qs"
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

    public class HelloQ : Operation<QVoid, QVoid>, ICallable
    {
        public HelloQ(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "HelloQ";
        String ICallable.FullName => "Quantum._11111.HelloQ";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> MicrosoftQuantumIntrinsicMessage
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

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            {
#line 19 "C:\\Users\\1712082018\\Desktop\\qsharp\\11111\\11111\\Operations.qs"
                var sabrina = Allocate.Apply();
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 20 "C:\\Users\\1712082018\\Desktop\\qsharp\\11111\\11111\\Operations.qs"
                    Set.Apply((sabrina, Result.One));
#line 21 "C:\\Users\\1712082018\\Desktop\\qsharp\\11111\\11111\\Operations.qs"
                    var rest = MicrosoftQuantumIntrinsicM.Apply(sabrina);
#line 23 "C:\\Users\\1712082018\\Desktop\\qsharp\\11111\\11111\\Operations.qs"
                    if ((rest == Result.Zero))
                    {
#line 24 "C:\\Users\\1712082018\\Desktop\\qsharp\\11111\\11111\\Operations.qs"
                        MicrosoftQuantumIntrinsicMessage.Apply("Vale nada! =D ");
                    }
                    else
                    {
#line 26 "C:\\Users\\1712082018\\Desktop\\qsharp\\11111\\11111\\Operations.qs"
                        MicrosoftQuantumIntrinsicMessage.Apply("Vale ummm");
                    }

#line 28 "C:\\Users\\1712082018\\Desktop\\qsharp\\11111\\11111\\Operations.qs"
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

#line 31 "C:\\Users\\1712082018\\Desktop\\qsharp\\11111\\11111\\Operations.qs"
            MicrosoftQuantumIntrinsicMessage.Apply("Hello quantum world!");
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.MicrosoftQuantumIntrinsicMessage = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.Set = this.Factory.Get<ICallable<(Qubit,Result), QVoid>>(typeof(Set));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<HelloQ, QVoid, QVoid>(QVoid.Instance);
        }
    }
}