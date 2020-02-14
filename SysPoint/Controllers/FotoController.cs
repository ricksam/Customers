﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SysPoint.Controllers
{
    public class FotoController : Controller
    {
        // GET: Foto
        /*public ActionResult Index()
        {
            return View();
        }*/

        public const string SEM_FOTO = "PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiPz48c3ZnIHZlcnNpb249IjEuMiIgYmFzZVByb2ZpbGU9InRpbnkiIHdpZHRoPSI3MC41Nm1tIiBoZWlnaHQ9IjcwLjU2bW0iIHZpZXdCb3g9IjAgMCA3MDU2IDcwNTYiIHByZXNlcnZlQXNwZWN0UmF0aW89InhNaWRZTWlkIiBmaWxsLXJ1bGU9ImV2ZW5vZGQiIHN0cm9rZS13aWR0aD0iMjguMjIyIiBzdHJva2UtbGluZWpvaW49InJvdW5kIiB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHhtbG5zOm9vbz0iaHR0cDovL3htbC5vcGVub2ZmaWNlLm9yZy9zdmcvZXhwb3J0IiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgeG1sOnNwYWNlPSJwcmVzZXJ2ZSI+IDxkZWZzIGNsYXNzPSJDbGlwUGF0aEdyb3VwIj4gIDxjbGlwUGF0aCBpZD0icHJlc2VudGF0aW9uX2NsaXBfcGF0aCIgY2xpcFBhdGhVbml0cz0idXNlclNwYWNlT25Vc2UiPiAgIDxyZWN0IHg9IjAiIHk9IjAiIHdpZHRoPSI3MDU2IiBoZWlnaHQ9IjcwNTYiLz4gIDwvY2xpcFBhdGg+IDwvZGVmcz4gPGRlZnM+ICA8Zm9udCBpZD0iRW1iZWRkZWRGb250XzEiIGhvcml6LWFkdi14PSIyMDQ4Ij4gICA8Zm9udC1mYWNlIGZvbnQtZmFtaWx5PSJBcmlhbCBlbWJlZGRlZCIgdW5pdHMtcGVyLWVtPSIyMDQ4IiBmb250LXdlaWdodD0iYm9sZCIgZm9udC1zdHlsZT0ibm9ybWFsIiBhc2NlbnQ9IjE4NzkiIGRlc2NlbnQ9IjQ3NiIvPiAgIDxtaXNzaW5nLWdseXBoIGhvcml6LWFkdi14PSIyMDQ4IiBkPSJNIDAsMCBMIDIwNDcsMCAyMDQ3LDIwNDcgMCwyMDQ3IDAsMCBaIi8+ICAgPGdseXBoIHVuaWNvZGU9Im0iIGhvcml6LWFkdi14PSIxNTYyIiBkPSJNIDEyNiwxMDYyIEwgMzg1LDEwNjIgMzg1LDkxNyBDIDQ3OCwxMDMwIDU4OCwxMDg2IDcxNiwxMDg2IDc4NCwxMDg2IDg0MywxMDcyIDg5MywxMDQ0IDk0MywxMDE2IDk4NCw5NzQgMTAxNiw5MTcgMTA2Myw5NzQgMTExMywxMDE2IDExNjcsMTA0NCAxMjIxLDEwNzIgMTI3OSwxMDg2IDEzNDAsMTA4NiAxNDE4LDEwODYgMTQ4NCwxMDcwIDE1MzgsMTAzOSAxNTkyLDEwMDcgMTYzMiw5NjAgMTY1OSw4OTkgMTY3OCw4NTQgMTY4OCw3ODAgMTY4OCw2NzkgTCAxNjg4LDAgMTQwNywwIDE0MDcsNjA3IEMgMTQwNyw3MTIgMTM5Nyw3ODAgMTM3OCw4MTEgMTM1Miw4NTEgMTMxMiw4NzEgMTI1OCw4NzEgMTIxOSw4NzEgMTE4Miw4NTkgMTE0Nyw4MzUgMTExMiw4MTEgMTA4Nyw3NzYgMTA3Miw3MzAgMTA1Nyw2ODMgMTA0OSw2MTAgMTA0OSw1MTAgTCAxMDQ5LDAgNzY4LDAgNzY4LDU4MiBDIDc2OCw2ODUgNzYzLDc1MiA3NTMsNzgyIDc0Myw4MTIgNzI4LDgzNCA3MDcsODQ5IDY4Niw4NjQgNjU3LDg3MSA2MjEsODcxIDU3OCw4NzEgNTM5LDg1OSA1MDQsODM2IDQ2OSw4MTMgNDQ1LDc3OSA0MzAsNzM1IDQxNSw2OTEgNDA3LDYxOCA0MDcsNTE2IEwgNDA3LDAgMTI2LDAgMTI2LDEwNjIgWiIvPiAgIDxnbHlwaCB1bmljb2RlPSJnIiBob3Jpei1hZHYteD0iMTAwNyIgZD0iTSAxMjEsLTcwIEwgNDQyLC0xMDkgQyA0NDcsLTE0NiA0NjAsLTE3MiA0NzksLTE4NiA1MDYsLTIwNiA1NDgsLTIxNiA2MDUsLTIxNiA2NzgsLTIxNiA3MzMsLTIwNSA3NzAsLTE4MyA3OTUsLTE2OCA4MTMsLTE0NSA4MjYsLTExMiA4MzUsLTg5IDgzOSwtNDYgODM5LDE3IEwgODM5LDE3MiBDIDc1NSw1NyA2NDksMCA1MjEsMCAzNzgsMCAyNjUsNjAgMTgyLDE4MSAxMTcsMjc2IDg0LDM5NSA4NCw1MzcgODQsNzE1IDEyNyw4NTEgMjEzLDk0NSAyOTgsMTAzOSA0MDUsMTA4NiA1MzIsMTA4NiA2NjMsMTA4NiA3NzIsMTAyOCA4NTcsOTEzIEwgODU3LDEwNjIgMTEyMCwxMDYyIDExMjAsMTA5IEMgMTEyMCwtMTYgMTExMCwtMTEwIDEwODksLTE3MiAxMDY4LC0yMzQgMTAzOSwtMjgzIDEwMDIsLTMxOCA5NjUsLTM1MyA5MTUsLTM4MSA4NTMsLTQwMSA3OTAsLTQyMSA3MTEsLTQzMSA2MTYsLTQzMSA0MzYsLTQzMSAzMDgsLTQwMCAyMzMsLTMzOCAxNTgsLTI3NyAxMjAsLTE5OSAxMjAsLTEwNCAxMjAsLTk1IDEyMCwtODMgMTIxLC03MCBaIE0gMzcyLDU1MyBDIDM3Miw0NDAgMzk0LDM1OCA0MzgsMzA2IDQ4MSwyNTMgNTM1LDIyNyA1OTksMjI3IDY2OCwyMjcgNzI2LDI1NCA3NzMsMzA4IDgyMCwzNjEgODQ0LDQ0MSA4NDQsNTQ2IDg0NCw2NTYgODIxLDczOCA3NzYsNzkxIDczMSw4NDQgNjczLDg3MSA2MDQsODcxIDUzNyw4NzEgNDgxLDg0NSA0MzgsNzkzIDM5NCw3NDAgMzcyLDY2MCAzNzIsNTUzIFoiLz4gICA8Z2x5cGggdW5pY29kZT0iZSIgaG9yaXotYWR2LXg9IjEwMDYiIGQ9Ik0gNzYyLDMzOCBMIDEwNDIsMjkxIEMgMTAwNiwxODggOTQ5LDExMCA4NzIsNTcgNzk0LDMgNjk3LC0yNCA1ODAsLTI0IDM5NSwtMjQgMjU5LDM2IDE3MCwxNTcgMTAwLDI1NCA2NSwzNzYgNjUsNTIzIDY1LDY5OSAxMTEsODM3IDIwMyw5MzcgMjk1LDEwMzYgNDExLDEwODYgNTUyLDEwODYgNzEwLDEwODYgODM1LDEwMzQgOTI2LDkzMCAxMDE3LDgyNSAxMDYxLDY2NSAxMDU3LDQ1MCBMIDM1Myw0NTAgQyAzNTUsMzY3IDM3OCwzMDIgNDIxLDI1NiA0NjQsMjA5IDUxOCwxODYgNTgzLDE4NiA2MjcsMTg2IDY2NCwxOTggNjk0LDIyMiA3MjQsMjQ2IDc0NywyODUgNzYyLDMzOCBaIE0gNzc4LDYyMiBDIDc3Niw3MDMgNzU1LDc2NSA3MTUsODA4IDY3NSw4NTAgNjI2LDg3MSA1NjksODcxIDUwOCw4NzEgNDU3LDg0OSA0MTcsODA0IDM3Nyw3NTkgMzU3LDY5OSAzNTgsNjIyIEwgNzc4LDYyMiBaIi8+ICAgPGdseXBoIHVuaWNvZGU9ImEiIGhvcml6LWFkdi14PSIxMDA2IiBkPSJNIDM1Nyw3MzggTCAxMDIsNzg0IEMgMTMxLDg4NyAxODAsOTYzIDI1MCwxMDEyIDMyMCwxMDYxIDQyNCwxMDg2IDU2MiwxMDg2IDY4NywxMDg2IDc4MSwxMDcxIDg0MiwxMDQyIDkwMywxMDEyIDk0Nyw5NzQgOTcyLDkyOSA5OTcsODgzIDEwMDksNzk5IDEwMDksNjc3IEwgMTAwNiwzNDkgQyAxMDA2LDI1NiAxMDExLDE4NyAxMDIwLDE0MyAxMDI5LDk4IDEwNDUsNTEgMTA3MCwwIEwgNzkyLDAgQyA3ODUsMTkgNzc2LDQ2IDc2NSw4MyA3NjAsMTAwIDc1NywxMTEgNzU1LDExNiA3MDcsNjkgNjU2LDM0IDYwMSwxMSA1NDYsLTEyIDQ4OCwtMjQgNDI2LC0yNCAzMTcsLTI0IDIzMSw2IDE2OCw2NSAxMDUsMTI0IDczLDE5OSA3MywyOTAgNzMsMzUwIDg3LDQwNCAxMTYsNDUxIDE0NSw0OTggMTg1LDUzNCAyMzcsNTU5IDI4OCw1ODQgMzYzLDYwNSA0NjAsNjI0IDU5MSw2NDkgNjgyLDY3MiA3MzMsNjkzIEwgNzMzLDcyMSBDIDczMyw3NzUgNzIwLDgxNCA2OTMsODM3IDY2Niw4NjAgNjE2LDg3MSA1NDIsODcxIDQ5Miw4NzEgNDUzLDg2MSA0MjUsODQyIDM5Nyw4MjIgMzc0LDc4NyAzNTcsNzM4IFogTSA3MzMsNTEwIEMgNjk3LDQ5OCA2NDAsNDg0IDU2Miw0NjcgNDg0LDQ1MCA0MzMsNDM0IDQwOSw0MTggMzcyLDM5MiAzNTQsMzU5IDM1NCwzMTkgMzU0LDI4MCAzNjksMjQ2IDM5OCwyMTcgNDI3LDE4OCA0NjUsMTc0IDUxMCwxNzQgNTYxLDE3NCA2MDksMTkxIDY1NSwyMjQgNjg5LDI0OSA3MTEsMjgwIDcyMiwzMTcgNzI5LDM0MSA3MzMsMzg3IDczMyw0NTQgTCA3MzMsNTEwIFoiLz4gICA8Z2x5cGggdW5pY29kZT0iUyIgaG9yaXotYWR2LXg9IjExOTIiIGQ9Ik0gNzQsNDc3IEwgMzYyLDUwNSBDIDM3OSw0MDggNDE1LDMzNyA0NjgsMjkyIDUyMSwyNDcgNTkyLDIyNCA2ODIsMjI0IDc3NywyMjQgODQ5LDI0NCA4OTgsMjg1IDk0NiwzMjUgOTcwLDM3MiA5NzAsNDI2IDk3MCw0NjEgOTYwLDQ5MCA5NDAsNTE1IDkxOSw1MzkgODg0LDU2MCA4MzMsNTc4IDc5OCw1OTAgNzE5LDYxMSA1OTYsNjQyIDQzNyw2ODEgMzI2LDczMCAyNjIsNzg3IDE3Miw4NjggMTI3LDk2NiAxMjcsMTA4MiAxMjcsMTE1NyAxNDgsMTIyNyAxOTEsMTI5MiAyMzMsMTM1NyAyOTQsMTQwNiAzNzQsMTQ0MCA0NTMsMTQ3NCA1NDksMTQ5MSA2NjIsMTQ5MSA4NDYsMTQ5MSA5ODUsMTQ1MSAxMDc4LDEzNzAgMTE3MSwxMjg5IDEyMTksMTE4MiAxMjI0LDEwNDcgTCA5MjgsMTAzNCBDIDkxNSwxMTA5IDg4OCwxMTY0IDg0NywxMTk3IDgwNSwxMjMwIDc0MiwxMjQ2IDY1OSwxMjQ2IDU3MywxMjQ2IDUwNiwxMjI4IDQ1NywxMTkzIDQyNiwxMTcwIDQxMCwxMTQwIDQxMCwxMTAyIDQxMCwxMDY3IDQyNSwxMDM4IDQ1NCwxMDEzIDQ5MSw5ODIgNTgyLDk0OSA3MjYsOTE1IDg3MCw4ODEgOTc3LDg0NiAxMDQ2LDgxMCAxMTE1LDc3MyAxMTY5LDcyNCAxMjA4LDY2MSAxMjQ3LDU5OCAxMjY2LDUyMCAxMjY2LDQyNyAxMjY2LDM0MyAxMjQzLDI2NCAxMTk2LDE5MSAxMTQ5LDExOCAxMDgzLDYzIDk5OCwyOCA5MTMsLTggODA2LC0yNiA2NzksLTI2IDQ5NCwtMjYgMzUxLDE3IDI1MiwxMDMgMTUzLDE4OCA5MywzMTMgNzQsNDc3IFoiLz4gICA8Z2x5cGggdW5pY29kZT0iSSIgaG9yaXotYWR2LXg9IjI5MiIgZD0iTSAxNDAsMCBMIDE0MCwxNDY2IDQzNiwxNDY2IDQzNiwwIDE0MCwwIFoiLz4gICA8Z2x5cGggdW5pY29kZT0iICIgaG9yaXotYWR2LXg9IjU1NiIvPiAgPC9mb250PiA8L2RlZnM+IDxkZWZzIGNsYXNzPSJUZXh0U2hhcGVJbmRleCI+ICA8ZyBvb286c2xpZGU9ImlkMSIgb29vOmlkLWxpc3Q9ImlkMyBpZDQgaWQ1IGlkNiIvPiA8L2RlZnM+IDxkZWZzIGNsYXNzPSJFbWJlZGRlZEJ1bGxldENoYXJzIj4gIDxnIGlkPSJidWxsZXQtY2hhci10ZW1wbGF0ZSg1NzM1NikiIHRyYW5zZm9ybT0ic2NhbGUoMC4wMDA0ODgyODEyNSwtMC4wMDA0ODgyODEyNSkiPiAgIDxwYXRoIGQ9Ik0gNTgwLDExNDEgTCAxMTYzLDU3MSA1ODAsMCAtNCw1NzEgNTgwLDExNDEgWiIvPiAgPC9nPiAgPGcgaWQ9ImJ1bGxldC1jaGFyLXRlbXBsYXRlKDU3MzU0KSIgdHJhbnNmb3JtPSJzY2FsZSgwLjAwMDQ4ODI4MTI1LC0wLjAwMDQ4ODI4MTI1KSI+ICAgPHBhdGggZD0iTSA4LDExMjggTCAxMTM3LDExMjggMTEzNywwIDgsMCA4LDExMjggWiIvPiAgPC9nPiAgPGcgaWQ9ImJ1bGxldC1jaGFyLXRlbXBsYXRlKDEwMTQ2KSIgdHJhbnNmb3JtPSJzY2FsZSgwLjAwMDQ4ODI4MTI1LC0wLjAwMDQ4ODI4MTI1KSI+ICAgPHBhdGggZD0iTSAxNzQsMCBMIDYwMiw3MzkgMTc0LDE0ODEgMTQ1Niw3MzkgMTc0LDAgWiBNIDEzNTgsNzM5IEwgMzA5LDEzNDYgNjU5LDczOSAxMzU4LDczOSBaIi8+ICA8L2c+ICA8ZyBpZD0iYnVsbGV0LWNoYXItdGVtcGxhdGUoMTAxMzIpIiB0cmFuc2Zvcm09InNjYWxlKDAuMDAwNDg4MjgxMjUsLTAuMDAwNDg4MjgxMjUpIj4gICA8cGF0aCBkPSJNIDIwMTUsNzM5IEwgMTI3NiwwIDcxNywwIDEyNjAsNTQzIDE3NCw1NDMgMTc0LDkzNiAxMjYwLDkzNiA3MTcsMTQ4MSAxMjc0LDE0ODEgMjAxNSw3MzkgWiIvPiAgPC9nPiAgPGcgaWQ9ImJ1bGxldC1jaGFyLXRlbXBsYXRlKDEwMDA3KSIgdHJhbnNmb3JtPSJzY2FsZSgwLjAwMDQ4ODI4MTI1LC0wLjAwMDQ4ODI4MTI1KSI+ICAgPHBhdGggZD0iTSAwLC0yIEMgLTcsMTQgLTE2LDI3IC0yNSwzNyBMIDM1Niw1NjcgQyAyNjIsODIzIDIxNSw5NTIgMjE1LDk1NCAyMTUsOTc5IDIyOCw5OTIgMjU1LDk5MiAyNjQsOTkyIDI3Niw5OTAgMjg5LDk4NyAzMTAsOTkxIDMzMSw5OTkgMzU0LDEwMTIgTCAzODEsOTk5IDQ5Miw3NDggNzcyLDEwNDkgODM2LDEwMjQgODYwLDEwNDkgQyA4ODEsMTAzOSA5MDEsMTAyNSA5MjIsMTAwNiA4ODYsOTM3IDgzNSw4NjMgNzcwLDc4NCA3NjksNzgzIDcxMCw3MTYgNTk0LDU4NCBMIDc3NCwyMjMgQyA3NzQsMTk2IDc1MywxNjggNzExLDEzOSBMIDcyNywxMTkgQyA3MTcsOTAgNjk5LDc2IDY3Miw3NiA2NDEsNzYgNTcwLDE3OCA0NTcsMzgxIEwgMTY0LC03NiBDIDE0MiwtMTEwIDExMSwtMTI3IDcyLC0xMjcgMzAsLTEyNyA5LC0xMTAgOCwtNzYgMSwtNjcgLTIsLTUyIC0yLC0zMiAtMiwtMjMgLTEsLTEzIDAsLTIgWiIvPiAgPC9nPiAgPGcgaWQ9ImJ1bGxldC1jaGFyLXRlbXBsYXRlKDEwMDA0KSIgdHJhbnNmb3JtPSJzY2FsZSgwLjAwMDQ4ODI4MTI1LC0wLjAwMDQ4ODI4MTI1KSI+ICAgPHBhdGggZD0iTSAyODUsLTMzIEMgMTgyLC0zMyAxMTEsMzAgNzQsMTU2IDUyLDIyOCA0MSwzMzMgNDEsNDcxIDQxLDU0OSA1NSw2MTYgODIsNjcyIDExNiw3NDMgMTY5LDc3OCAyNDAsNzc4IDI5Myw3NzggMzI4LDc0NyAzNDYsNjg0IEwgMzY5LDUwOCBDIDM3Nyw0NDQgMzk3LDQxMSA0MjgsNDEwIEwgMTE2MywxMTE2IEMgMTE3NCwxMTI3IDExOTYsMTEzMyAxMjI5LDExMzMgMTI3MSwxMTMzIDEyOTIsMTExOCAxMjkyLDEwODcgTCAxMjkyLDk2NSBDIDEyOTIsOTI5IDEyODIsOTAxIDEyNjIsODgxIEwgNDQyLDQ3IEMgMzkwLC02IDMzOCwtMzMgMjg1LC0zMyBaIi8+ICA8L2c+ICA8ZyBpZD0iYnVsbGV0LWNoYXItdGVtcGxhdGUoOTY3OSkiIHRyYW5zZm9ybT0ic2NhbGUoMC4wMDA0ODgyODEyNSwtMC4wMDA0ODgyODEyNSkiPiAgIDxwYXRoIGQ9Ik0gODEzLDAgQyA2MzIsMCA0ODksNTQgMzgzLDE2MSAyNzYsMjY4IDIyMyw0MTEgMjIzLDU5MiAyMjMsNzczIDI3Niw5MTYgMzgzLDEwMjMgNDg5LDExMzAgNjMyLDExODQgODEzLDExODQgOTkyLDExODQgMTEzNiwxMTMwIDEyNDUsMTAyMyAxMzUzLDkxNiAxNDA3LDc3MiAxNDA3LDU5MiAxNDA3LDQxMiAxMzUzLDI2OCAxMjQ1LDE2MSAxMTM2LDU0IDk5MiwwIDgxMywwIFoiLz4gIDwvZz4gIDxnIGlkPSJidWxsZXQtY2hhci10ZW1wbGF0ZSg4MjI2KSIgdHJhbnNmb3JtPSJzY2FsZSgwLjAwMDQ4ODI4MTI1LC0wLjAwMDQ4ODI4MTI1KSI+ICAgPHBhdGggZD0iTSAzNDYsNDU3IEMgMjczLDQ1NyAyMDksNDgzIDE1NSw1MzUgMTAxLDU4NiA3NCw2NDkgNzQsNzIzIDc0LDc5NiAxMDEsODU5IDE1NSw5MTEgMjA5LDk2MyAyNzMsOTg5IDM0Niw5ODkgNDE5LDk4OSA0ODAsOTYzIDUzMSw5MTAgNTgyLDg1OSA2MDgsNzk2IDYwOCw3MjMgNjA4LDY0OCA1ODMsNTg2IDUzMiw1MzUgNDgyLDQ4MyA0MjAsNDU3IDM0Niw0NTcgWiIvPiAgPC9nPiAgPGcgaWQ9ImJ1bGxldC1jaGFyLXRlbXBsYXRlKDgyMTEpIiB0cmFuc2Zvcm09InNjYWxlKDAuMDAwNDg4MjgxMjUsLTAuMDAwNDg4MjgxMjUpIj4gICA8cGF0aCBkPSJNIC00LDQ1OSBMIDExMzUsNDU5IDExMzUsNjA2IC00LDYwNiAtNCw0NTkgWiIvPiAgPC9nPiA8L2RlZnM+IDxkZWZzIGNsYXNzPSJUZXh0RW1iZWRkZWRCaXRtYXBzIi8+IDxnPiAgPGcgaWQ9ImlkMiIgY2xhc3M9Ik1hc3Rlcl9TbGlkZSI+ICAgPGcgaWQ9ImJnLWlkMiIgY2xhc3M9IkJhY2tncm91bmQiLz4gICA8ZyBpZD0iYm8taWQyIiBjbGFzcz0iQmFja2dyb3VuZE9iamVjdHMiLz4gIDwvZz4gPC9nPiA8ZyBjbGFzcz0iU2xpZGVHcm91cCI+ICA8Zz4gICA8ZyBpZD0iaWQxIiBjbGFzcz0iU2xpZGUiIGNsaXAtcGF0aD0idXJsKCNwcmVzZW50YXRpb25fY2xpcF9wYXRoKSI+ICAgIDxnIGNsYXNzPSJQYWdlIj4gICAgIDxnIGNsYXNzPSJjb20uc3VuLnN0YXIuZHJhd2luZy5Qb2x5UG9seWdvblNoYXBlIj4gICAgICA8ZyBpZD0iaWQzIj4gICAgICAgPHBhdGggZmlsbD0icmdiKDI1NSwyNTUsMjU1KSIgc3Ryb2tlPSJub25lIiBkPSJNIDM3NTAsMzc2NiBMIDMxMDAsNDE0MSAyMTAwLDI0MDkgMzQwMCwxNjU5IDQ0MDAsMzM5MSAzNzUwLDM3NjYgWiIvPiAgICAgICA8cGF0aCBmaWxsPSJub25lIiBzdHJva2U9InJnYigyMDQsMjA0LDIwNCkiIHN0cm9rZS13aWR0aD0iMTAwIiBzdHJva2UtbGluZWpvaW49Im1pdGVyIiBkPSJNIDM3NTAsMzc2NiBMIDMxMDAsNDE0MSAyMTAwLDI0MDkgMzQwMCwxNjU5IDQ0MDAsMzM5MSAzNzUwLDM3NjYgWiIvPiAgICAgIDwvZz4gICAgIDwvZz4gICAgIDxnIGNsYXNzPSJjb20uc3VuLnN0YXIuZHJhd2luZy5UZXh0U2hhcGUiPiAgICAgIDxnIGlkPSJpZDQiPiAgICAgICA8dGV4dCBjbGFzcz0iVGV4dFNoYXBlIj48dHNwYW4gY2xhc3M9IlRleHRQYXJhZ3JhcGgiIGZvbnQtZmFtaWx5PSJBcmlhbCwgc2Fucy1zZXJpZiIgZm9udC1zaXplPSI0OTRweCIgZm9udC13ZWlnaHQ9IjcwMCI+PHRzcGFuIGNsYXNzPSJUZXh0UG9zaXRpb24iIHg9IjIwNDIiIHk9IjUwODkiLz48dHNwYW4gY2xhc3M9IlRleHRQb3NpdGlvbiIgeD0iMjA0MiIgeT0iNTA4OSI+PHRzcGFuIGZpbGw9InJnYigxNzgsMTc4LDE3OCkiIHN0cm9rZT0ibm9uZSI+U2VtIEltYWdlbTwvdHNwYW4+PC90c3Bhbj48L3RzcGFuPjwvdGV4dD4gICAgICA8L2c+ICAgICA8L2c+ICAgICA8ZyBjbGFzcz0iY29tLnN1bi5zdGFyLmRyYXdpbmcuUG9seVBvbHlnb25TaGFwZSI+ICAgICAgPGcgaWQ9ImlkNSI+ICAgICAgIDxwYXRoIGZpbGw9InJnYigyNTUsMjU1LDI1NSkiIHN0cm9rZT0ibm9uZSIgZD0iTSAzODc2LDM5MjYgTCAzMTUxLDQxMjAgMjYzNCwyMTg4IDQwODMsMTgwMCA0NjAwLDM3MzIgMzg3NiwzOTI2IFoiLz4gICAgICAgPHBhdGggZmlsbD0ibm9uZSIgc3Ryb2tlPSJyZ2IoMjA0LDIwNCwyMDQpIiBzdHJva2Utd2lkdGg9IjEwMCIgc3Ryb2tlLWxpbmVqb2luPSJtaXRlciIgZD0iTSAzODc2LDM5MjYgTCAzMTUxLDQxMjAgMjYzNCwyMTg4IDQwODMsMTgwMCA0NjAwLDM3MzIgMzg3NiwzOTI2IFoiLz4gICAgICA8L2c+ICAgICA8L2c+ICAgICA8ZyBjbGFzcz0iY29tLnN1bi5zdGFyLmRyYXdpbmcuUG9seVBvbHlnb25TaGFwZSI+ICAgICAgPGcgaWQ9ImlkNiI+ICAgICAgIDxwYXRoIGZpbGw9InJnYigyNTUsMjU1LDI1NSkiIHN0cm9rZT0ibm9uZSIgZD0iTSAzODUwLDQxMDAgTCAzMTAwLDQxMDAgMzEwMCwyMTAwIDQ2MDAsMjEwMCA0NjAwLDQxMDAgMzg1MCw0MTAwIFoiLz4gICAgICAgPHBhdGggZmlsbD0ibm9uZSIgc3Ryb2tlPSJyZ2IoMjA0LDIwNCwyMDQpIiBzdHJva2Utd2lkdGg9IjEwMCIgc3Ryb2tlLWxpbmVqb2luPSJtaXRlciIgZD0iTSAzODUwLDQxMDAgTCAzMTAwLDQxMDAgMzEwMCwyMTAwIDQ2MDAsMjEwMCA0NjAwLDQxMDAgMzg1MCw0MTAwIFoiLz4gICAgICA8L2c+ICAgICA8L2c+ICAgIDwvZz4gICA8L2c+ICA8L2c+IDwvZz48L3N2Zz4=";

        public FileContentResult Index(int id = 0) {
            try {
                Models.Fotos foto = Models.Fotos.Find(id);

                using (var MemoryStream = new System.IO.MemoryStream())
                {
                    System.Drawing.Image Jpeg = lib.Class.ProcessImage.StringToImage(foto.Foto);
                    Jpeg.Save(MemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);

                    return File(MemoryStream.GetBuffer(), "image/jpeg");
                }
            }
            catch {
                using (var MemoryStream = new System.IO.MemoryStream())
                {
                    System.Drawing.Image Jpeg = lib.Class.ProcessImage.StringToImage(SEM_FOTO);
                    Jpeg.Save(MemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);

                    return File(MemoryStream.GetBuffer(), "image/jpeg");
                }
            }
            
        }
    }
}