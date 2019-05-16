namespace Quantum._11111
{
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;
    
	operation Set(sabrina : Qubit, value : Result): Unit{
		let rest = M(sabrina);

		if (rest != value){
			X(sabrina);
		}
	}

    operation HelloQ () : Unit {
        
		using(sabrina = Qubit()){
			let rest = M(sabrina);
			if(rest == Zero){
				Message("Cara");
			}else{
				Message("Coroa");
			}
			Set(sabrina, Zero);
		}
		
		Message("Hello quantum world!");
		
    }
}
