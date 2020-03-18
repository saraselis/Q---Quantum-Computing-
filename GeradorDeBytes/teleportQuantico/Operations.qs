namespace Quantum.GeradorDeBytes
{
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;
    
	operation Set(qubit : Qubit, value : Result) : Unit{
		let res = M(qubit);
		if(res != value){
			X(qubit);
		}
	}

	operation ResToInt(result : Result) : Int{
		if(result == Zero){
			return 0;
		}else{
			return 1;
		}
	}

    operation BinaryGen (bitCount : Int) : Int[] {
		mutable res = new Int[bitCount];
		using(qubit = Qubit()){
			for(i in 0..bitCount-1){
				Set(qubit, Zero);
				H(qubit);
				set res w/= i <- ResToInt(M(qubit));
			}
			Set(qubit, Zero);
		}
		return res;
    }
}
