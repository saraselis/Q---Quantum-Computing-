namespace Quantum.pedraPapelTesoura
{
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;
    
    operation Set(q : Qubit, v : Result) : Unit{
		if(M(q) != v){
			X(q);
		}
	}
	
	operation Play() : Int{
		mutable r = 0;
		using(q = Qubit()){
			Set(q, Zero);
			H(q);
			R(PauliY, 0.3255, q);
			let res = M(q);
			if(res == Zero){
				set r = 0;
			}else{
				Set(q, Zero);
				H(q);
				let resF = M(q);
				if(resF == Zero){
					set r = 1;
				}else{
					set r = 2;
				}
			}
			Set(q, Zero);
		}
		return r;
}
}