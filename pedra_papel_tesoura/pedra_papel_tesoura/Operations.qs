namespace Quantum.pedra_papel_tesoura
{
	operation Set(q : Qubit, v :  Result) : Unit{
		if(M(q) != v){
			X(q);
		}
	}

	operation Play(): Int {
		mutable r = 0;
		using(q = Qubit()){
			Set(q, Zero);
			M(q);
			R(PauliY, 0,3255,q);
			let rest = M(q);

			if (rest == Zero){
				set r=0;
			}else{
				Set(q, Zero);
				M(q);
				let restFinal = M(q);

				if (restFinal == Zero){
					set r=1;

				}else{
					set r=2;
				}
			}

			Set(q,Zero);
		}
		
		return r;

	}

}
