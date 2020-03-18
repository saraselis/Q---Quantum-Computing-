namespace Quantum.teleportQuantico
{
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;
    
	operation Set(qbit: Qubit, value: Result): Unit{
		let res = M(qbit);
		if(res != value){
			X(qbit);
		}
	}
	operation SendMensage(msg: Int) : Unit{
		using(there = Wubit()){
		
		}
	}

	operation Teleport(msg: Qubit, there: Qubit){
		using(here = Qubit()){
			H(here);
			CNOT(here, there); //entrelaçamento

			CNOT(msg, here);

			H(msg);
			
			if(M(msg)==One){
			Z(there);
			}if (M(here)==One){
				X(there);
			}
			Set(here,Zero);
		}
	}
}
