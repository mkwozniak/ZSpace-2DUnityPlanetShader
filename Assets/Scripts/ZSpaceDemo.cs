namespace Wozware.ZSpaceDemo
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using TMPUI = TMPro.TextMeshProUGUI;

	[System.Serializable]
	public struct PlanetSelectionData
	{
		public string PlanetNameType;
		public GameObject PlanetObject;
		public float CamZoom;
	}

	public class ZSpaceDemo : MonoBehaviour
	{
		public Camera Cam;
		public float ZoomSpeed;
		public List<PlanetSelectionData> Planets;
		public PlanetSelectionData CurrentPlanet;
		public TMPUI PlanetTypeTitleText;

		private int _currIndex = 0;
		[SerializeField] private float _sizeT = 0f;
		[SerializeField] private bool _switchedPlanet;

		private void Start()
		{
			CurrentPlanet = Planets[0];
			SetPlanet(0);
		}

		private void Update()
		{
			if(_switchedPlanet)
			{
				Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, CurrentPlanet.CamZoom, _sizeT);
				_sizeT += Time.deltaTime * ZoomSpeed;
				if (_sizeT > 1f)
				{
					_switchedPlanet = false;
				}
			}
		}

		private void SetPlanet(int id)
		{
			_sizeT = 0f;
			CurrentPlanet.PlanetObject.SetActive(false);
			CurrentPlanet = Planets[id];
			CurrentPlanet.PlanetObject.SetActive(true);
			PlanetTypeTitleText.text = CurrentPlanet.PlanetNameType;
			_switchedPlanet = true;
		}

		public void NextPlanet()
		{
			_currIndex += 1;
			if(_currIndex >= Planets.Count)
			{
				_currIndex = 0;
			}
			SetPlanet(_currIndex);
		}

		public void PreviousPlanet()
		{
			_currIndex -= 1;
			if (_currIndex < 0)
			{
				_currIndex = Planets.Count - 1;
			}
			SetPlanet(_currIndex);
		}

	}

}
