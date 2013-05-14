﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Catan.IFace;

namespace Catan.ViewModel {
	/// <summary>
	/// Ablak bezáró service
	/// </summary>
	class WPFWindowService : IWindowService {
		/// <summary>
		/// Ablak
		/// </summary>
		protected Window Window;

		/// <summary>
		/// Konstruktor
		/// </summary>
		/// <param name="window">Ablak</param>
		public WPFWindowService(Window window) {
			Window = window;
		}

		/// <summary>
		/// Ablak bezárása
		/// </summary>
		public void Close() {
			Window.Close();
		}

	}
}