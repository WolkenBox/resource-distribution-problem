using System;

namespace ResDist {

	/// <summary>Хранит цену и эффективность оружия</summary>
	public struct WeaponType {
		public int Price, Effect;
	};

	/// <summary>Решает задачу распределения ресурсов</summary>
	public class Task {
		public static int[,] F;
		public static int[,] X;
		public static int[] Plan;
		public static int NeedPrice;

		// -----------------------------------------------------------
		/// <summary>
		/// Решает задачу распределения ресурсов
		/// </summary>
		/// <param name="W0">Сколько денег у нас есть</param>
		/// <param name="WeapTypes">Типы оружия на складе</param>
		public static void Solve(int W0, WeaponType[] WeapTypes) {
			int N = WeapTypes.Length, W, k, i;
			
			F = new int[W0+1, N];
			X = new int[W0+1, N];
			Plan = new int[N];

			for(W = 0; W <= W0; W++) {
				for(k = 1; k <= N; k++) {
					X[W, k-1] = W / WeapTypes[k-1].Price;
					if(k == 1)
						F[W, k-1] = WeapTypes[k-1].Effect * X[W, k-1];
					else {
						F[W, k-1] = WeapTypes[k-1].Effect * X[W, k-1] + 
							F[W - WeapTypes[k-1].Price * X[W, k-1], k - 2];
					}
				}
			}

			Plan[N-1] = X[W0, N-1];
			NeedPrice = F[W0, N-1];
			for(i = 1; i < N; i++) {
				Plan[N-i-1] = X[W0 - WeapTypes[N-i].Price * Plan[N-i], N-i];
			}
		}
	}

}
