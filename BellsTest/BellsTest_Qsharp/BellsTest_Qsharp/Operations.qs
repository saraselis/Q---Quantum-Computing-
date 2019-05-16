namespace Quantum.BellsTest_Qsharp
{
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;
    
    operation Set (sabrina: Qubit, value: Result) : Unit {
		let rest = M(sabrina);
		if(rest != value){
			X(sabrina);
		}
    }

	operation Bells(count : Int ) : (Int, Int){
		mutable k = 0;

		using(sabrina = Qubit()){
			for (test in 1..count){
				Set(sabrina, Zero);
				H(sabrina);

				let medicao = M(sabrina);

				if(medicao == One){
					set k += 1 ;

				}
			}
			Set(sabrina, Zero);
		}
		return (count-k,k);
	}

}
