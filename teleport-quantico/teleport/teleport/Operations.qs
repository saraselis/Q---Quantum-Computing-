namespace Quantum.QApplication
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    operation Set (v: Result, q: Qubit) : Unit {
        let current = M(q);
		if (v != current){
			X(q);
		}
    }

	operation Teleport(msg: Qubit, there: Qubit) : Unit{
		using(here = Qubit()){
			
			H(here);
			CNOT(here, there);

			CNOT(msg, here);
			H(msg);
			
			if(M(msg) == One) {Z(there);}
			if(M(here) == One) {X(there);}

			Set(Zero, here);
		}
	}

	operation SendMessage(value: Int) : Int
	{
		mutable res = 0;
		using((msg, target) = (Qubit(), Qubit())){
			
			if(value == 1) {X(msg);}
			
			Teleport(msg, target);
			
			if(M(target) == One){
				set res = 1;
			}

			Set(Zero, target);
			Set(Zero, msg);

			return res;
		}
	}
}