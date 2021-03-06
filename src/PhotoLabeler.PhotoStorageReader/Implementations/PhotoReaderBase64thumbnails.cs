// Copyright (c) Juanjo Montiel and contributors. All Rights Reserved. Licensed under the GNU General Public License, Version 2.0. See LICENSE in the project root for license information.

namespace PhotoLabeler.PhotoStorageReader.Implementations
{
	// Nothing relevant in this file, only 100x100 pixels for non images or non suported images.

	public static class PhotoReaderBase64thumbnails
	{
		internal const string B64VideoThumbnail =
			"data:image/jpeg;base64,/9j/4AAQSkZJRgABAQEAYABgAAD/2wCEAAgGBgcGBQgHBwcJCQgKDBQND" +
			"AsLDBkSEw8UHRofHh0aHBwgJC4nICIsIxwcKDcpLDAxNDQ0Hyc5PTgyPC4zNDIBCQkJDAsMGA0NGDIhH" +
			"CEyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMv/AABEIAGQAZ" +
			"AMBIgACEQEDEQH/xAGiAAABBQEBAQEBAQAAAAAAAAAAAQIDBAUGBwgJCgsQAAIBAwMCBAMFBQQEAAABf" +
			"QECAwAEEQUSITFBBhNRYQcicRQygZGhCCNCscEVUtHwJDNicoIJChYXGBkaJSYnKCkqNDU2Nzg5OkNER" +
			"UZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6g4SFhoeIiYqSk5SVlpeYmZqio6Slpqeoqaqys7S1t" +
			"re4ubrCw8TFxsfIycrS09TV1tfY2drh4uPk5ebn6Onq8fLz9PX29/j5+gEAAwEBAQEBAQEBAQAAAAAAA" +
			"AECAwQFBgcICQoLEQACAQIEBAMEBwUEBAABAncAAQIDEQQFITEGEkFRB2FxEyIygQgUQpGhscEJIzNS8" +
			"BVictEKFiQ04SXxFxgZGiYnKCkqNTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqCg" +
			"4SFhoeIiYqSk5SVlpeYmZqio6Slpqeoqaqys7S1tre4ubrCw8TFxsfIycrS09TV1tfY2dri4+Tl5ufo6" +
			"ery8/T19vf4+fr/2gAMAwEAAhEDEQA/APf6KKKACisLxX4u0fwbpDajq9x5adIol5kmb+6o7n9B3r5j8" +
			"b/GTxH4tkkt7aZ9L0s5At7d8M4/236n6DA9qAPo7xB8SvCPhlmj1HWrf7QvWCDMsgPoQucfjiuDvf2j/" +
			"DkLlbLSNSuQP4n2Rg/qTXzzpGgav4gufs+k6bc3svcQxlgv1PQfjXoGnfADxveorzx2NiD/AA3Fxkj/A" +
			"L4DUAd1H+0tppb954cu1X1W4Un8sCug0r4/+C9QdUunvdOY8ZuINy/mhb+Veay/s4+K0TMepaRI393zJ" +
			"B/7JXLa38IfG+hRtLNoslzCvJks2Ew/IfN+lAH1xpWs6ZrlqLrS7+2vID/HBIHA9jjofrV6vg/TNW1Tw" +
			"/qAutNvLiyu4zjdExU/Qjv9DXv/AMO/j1DqMsWl+LfLtrhvlj1BBtjc+jj+E+44+lAHuNFICGUMpBBGQ" +
			"R3paACiiigArE8WeKNP8H+HbnWNRY+XEMJGp+aVz91F9z+gye1bdfJ/xu8at4m8YSabbS503S2MKAHh5" +
			"f43/P5R7D3oA43xb4t1TxnrsuqapLlm4iiU/JCnZVHp/PrXqnw1+Bb6pBDrPixZIbV8PDp4JV5B2Mh6q" +
			"PYc/So/gV8OItXuP+Eq1eAPZ28m2yiccSyDq5HcKenv9K+kqAKunaZY6RZJZ6daQ2ttGMLFCgVR+Aq1R" +
			"US3Vu1y1ss8RnUbmiDjcB6kdaAJaKKKAOO8Z/DPw542gdr21W3v8fJfQALID23f3h7H8MV8seN/Amr+B" +
			"dW+x6lGHgkybe6jH7uZfb0I7jt9MGvtisbxT4Y07xfoFxpGpR7opRlHA+aJ+zr7j/63egDwz4KfFSSzu" +
			"YPCmu3Ba0kISxuJDzE3aMn+6eg9Dx06fRlfC3iTw/feFfEV3o98NtxayYDDgOvVWHsRg19U/B/xo3jHw" +
			"XEbqTfqVgRb3JJ5fj5X/EfqDQB6BRRRQBz/AI410+GvBOr6srYlgt28o/8ATRvlT/x4ivi3TLC41rWbT" +
			"T4Mtc3k6xKTzlmbGT+dfTX7Qt4bb4bxwKcfar6KMj1ADN/NRXjnwQ09b/4qaaXGVtklnx7hCB+pFAH1b" +
			"ouk22haLZ6VZrtt7SJYk98Dqfc9T9avUUUAFfDd3rmqWPjG81e2v54tQW7kcXCv82dx6+o9ulfclfBmr" +
			"f8AIYvv+viT/wBCNAH0x8NfjVY+J/K0rXjFY6ucKkmdsVyfb+63t0Pb0r1uvgCvafhr8cbnR/J0jxTJJ" +
			"daeMJFe8tLAOwbu6/qPfpQB9LUVBZ3ltqNnFeWc8dxbTKHjljYMrD1BFT0AeF/tGeGEm0uw8TQRjzrd/" +
			"stwQOqNkoT9GyP+BVw3wE19tJ+IiWDPiDU4mgYdt6jch/Qj/gVfQHxOsF1L4Z+IIGXO2zeZfqnzj9Vr5" +
			"G8I3rad4y0W8U4MN9C34bxn9KAPuaiiigDx39o6Jn8CadIPupqK5/GN68z+AEqx/E+JW6yWkyr9cA/yB" +
			"r27406S2rfC7VBGu6S12XSj2Rvm/wDHS1fM3w91tfDvj/RdTkbbDHcBJW9Ef5GP4BiaAPtmiiigAr4M1" +
			"b/kM33/AF8Sf+hGvvOvgzVv+Qzff9fEn/oRoAp0qqzsFVSzMcAAZJNaGiaHqXiPVItN0m0kurqU8Ig6D" +
			"uSegA9TX1B8N/g7pvg1YtR1Ly7/AFvGRIRmO3PogPf/AGjz6YoAj+BnhfXvDXhW6/toPAt3KstvZyH5o" +
			"hjkkfwluOPbmvUqKKAMDxzMtv4B8QyP90adP+sZFfF2iRtNr+nRL957qJR9Swr6l+OuuLpPw1urYOBPq" +
			"MiWyDvjO5j+SkfjXz58KtJbWfiZoduF3JFcC4f0Cx/P/MAfjQB9nUUUUARXVtFeWk1rOgeGaNo5FP8AE" +
			"pGCPyNfD3izw9ceFfFGoaNcg7raUhGI++h5VvxUg19zV5H8cPh2/ibSF17S4d+qWCESRqPmnh6kD1ZeS" +
			"PXJHpQBr/BzxvH4t8HQ29xKDqmnKsFwpPLqBhJPxAwfcGvRa+HPCfirUfB3iCDV9NcCSP5ZI2+7Kh6o3" +
			"sf0OD2r6+8GeONH8caQt7pkwEqgefauf3kLehHceh6H9KAOlr5cf4E+LL/xpdW0qQ2+mtO7/wBoF1ZSh" +
			"bIwoO4tjscc9+9fUdFAHO+EPBOi+CdLFlpNvh2A864fmSY+rH+g4FdFRRQAUUV4L8YPjDCtvceGvDNyJ" +
			"JHBjvL2JuFHdEPcnoSOnQc9ADhPjT43Txb4v+zWUu/TNNDQwsDxI+fnce2QAPZc967v9nPwq0UF/wCKb" +
			"iPHm/6LakjqoOXYfiFH4GvHPBPhC/8AG3iSDSrJSqE77ifGRDGOrH+QHckV9oaTpVpomkWumWEXl2trG" +
			"I419h3PqT1J9aALtFFFABRRRQB4R8V/gq99NP4g8KwDz3Je609Bjee7x+/qvftzwfB9N1TVfDerC70+5" +
			"uLC+gYruXKsp7qQf1Br7vrjPGXwv8NeNQ0t9am3v8YF7bYWT/gXZh9fwIoA8x8LftGlY0t/FGmM7Dg3d" +
			"ljJ9zGT/I/hXpenfF3wLqUYaPxBbwk9VuQ0RH/fQArxPxB+z34o053fSJrbVYB90BhFLj3Vjj8mrg77w" +
			"H4t05yt14c1RMdxbMy/mARQB9byfEbwXEm5vFGlY/2blWP5A1y2t/HrwXpaMLOe41OYdFt4iq592fH6Z" +
			"r5lj8M6/K22PQ9SdvRbSQn+VdDpXwk8cau6iLQLi3Q/x3eIQP8AvrB/IUAaPjb4z+I/F0clnCw0vTX4a" +
			"C3Y7pB6O/U/QYHsa5vwf4J1rxtqi2elW5MakedcuCIoR6sfX2HJr2Xwt+znbwOlx4o1L7QRybSzyqH2L" +
			"nk/gB9a9r0vSrDRbCOx0yzhtLWP7sUS7QPf3PvQBi+CPA+l+BdEXT9PXfM+GuLlx88z+p9AOw7fXJPTU" +
			"UUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQB//9k=";
		internal const string B64FileThumbnail =
			"data:image/jpeg;base64,/9j/4AAQSkZJRgABAQEAYABgAAD/2wCEAAgGBgcGBQgHBwcJCQgKDBQND" +
			"AsLDBkSEw8UHRofHh0aHBwgJC4nICIsIxwcKDcpLDAxNDQ0Hyc5PTgyPC4zNDIBCQkJDAsMGA0NGDIhH" +
			"CEyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMv/AABEIAGQAZ" +
			"AMBIgACEQEDEQH/xAGiAAABBQEBAQEBAQAAAAAAAAAAAQIDBAUGBwgJCgsQAAIBAwMCBAMFBQQEAAABf" +
			"QECAwAEEQUSITFBBhNRYQcicRQygZGhCCNCscEVUtHwJDNicoIJChYXGBkaJSYnKCkqNDU2Nzg5OkNER" +
			"UZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6g4SFhoeIiYqSk5SVlpeYmZqio6Slpqeoqaqys7S1t" +
			"re4ubrCw8TFxsfIycrS09TV1tfY2drh4uPk5ebn6Onq8fLz9PX29/j5+gEAAwEBAQEBAQEBAQAAAAAAA" +
			"AECAwQFBgcICQoLEQACAQIEBAMEBwUEBAABAncAAQIDEQQFITEGEkFRB2FxEyIygQgUQpGhscEJIzNS8" +
			"BVictEKFiQ04SXxFxgZGiYnKCkqNTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqCg" +
			"4SFhoeIiYqSk5SVlpeYmZqio6Slpqeoqaqys7S1tre4ubrCw8TFxsfIycrS09TV1tfY2dri4+Tl5ufo6" +
			"ery8/T19vf4+fr/2gAMAwEAAhEDEQA/APf6pavq1loek3WqahMIbS2QySORnA9h3J6Aepq7Xm3x2JHwp" +
			"1DBIzNAD/38FAHJ3H7S2nrO62/hu5khB+V5LpUYj3AU4/M1H/w0xa/9CvN/4Gj/AOIryb4deDU8deKP7" +
			"HkvWs18h5vNWPeflI4xketes/8ADM9r/wBDRN/4BD/4ugA/4aYtf+hXm/8AA0f/ABFH/DTFr/0K83/ga" +
			"P8A4ij/AIZntf8AoaJv/AIf/F0f8Mz2v/Q0Tf8AgEP/AIugCSD9pbT2lUXHhq5jj7tHdK5H4FR/OvUPC" +
			"Xj3w941t2k0e9DTIMyW0o2Sxj1K9x7jI96+Zfih8N4vh3PpkcWpvffbVkYloRHs2lfc5+9+lcbo+sX+g" +
			"arb6nply9vdwNuR1/kR3B6Ed6APvGiuG+G3xJsPH2lfwW+rQKPtNrn/AMfT1U/p0PYnuaACiiigAoooo" +
			"AK82+O//JKdQ/67Qf8AowV6TXm3x3/5JTqH/XaD/wBGCgDx79nz/kph/wCvGX+a19VV8q/s+f8AJTD/A" +
			"NeMv81r6qoAKKKKAPnn9pj/AI/fDn/XO4/nHXPfDb4cWfj7wFrQDLBqttdKbW5PT7n3G/2T+Y6+oPQ/t" +
			"Mf8fvhz/rncfzjrY/Zr/wCRa1v/AK/E/wDQKAPClbXvAfirI87T9WsJPy/oykfgQa+qvhv8SLDx9pX8F" +
			"vq0Cj7Ta5/8fT1U/p0PYlvxK+Gth490vcuy31eBT9musdf9h/VT+nUdwfldW17wH4qyPO0/VrCT8v6Mp" +
			"H4EGgD7jorh/hv8SLDx9pX8Fvq0Cj7Ta5/8fT1U/p0PYnuKACiiigArzb47/wDJKdQ/67Qf+jBXpNebf" +
			"Hf/AJJTqH/XaD/0YKAPHv2fP+SmH/rxl/mtfVVfKv7Pn/JTD/14y/zWvqqgAooooA+fv2l7eUv4duQh8" +
			"kCeMv2DHYQPyB/KvMvBvxL17wNZXNrpC2hjuJBI/nxFzkDHGCK+vta0PTPEWmSabq1nHdWknJjcdCOhB" +
			"HIPuOa4U/AfwET/AMg+5H/b3J/jQB5B/wANCeNv7ul/+Ax/+Krk/GPj/VPHBt31e108TwcJPBCUkK/3S" +
			"cnI7+34mvov/hQ/gL/oH3P/AIFv/jR/wofwF/0D7n/wLf8AxoA+W9C1u+8O61a6rpsxiurdwykdCO6n1" +
			"BHBFfbugaxB4g8P2Gr23EV5AsoH93I5H4HI/Cvkb4q+HNN8K+PLrSdKieK0jiiZVdy5yygnk+9fRvwYY" +
			"t8JtDyc4WUf+RXoA72iiigArzb47/8AJKdQ/wCu0H/owV6TXm3x3/5JTqH/AF2g/wDRgoA8e/Z8/wCSm" +
			"H/rxl/mtex/GnxXq/hHwdb3mi3C29zNeLCZSiuQu1mOAwI/hFeOfs+f8lMP/XjL/Na+mtZ0LS/ENh9h1" +
			"exhvLbcH8uUZAYdCPQ8n86APk7/AIXT8QP+g+3/AIDQ/wDxFH/C6fiB/wBB9v8AwGh/+Ir6P/4VP4E/6" +
			"Fqz/wDHv8aP+FT+BP8AoWrP/wAe/wAaAPnD/hdPxA/6D7f+A0P/AMRR/wALp+IH/Qfb/wABof8A4ivo/" +
			"wD4VP4E/wChas//AB7/ABo/4VP4E/6Fqz/8e/xoA+cP+F0/ED/oPt/4DQ//ABFfQfwe8T6p4s8CrqGsT" +
			"rPdpcyQmUIF3AYIyBgZ5q5/wqfwJ/0LVn/49/jXSaRo2naDp6WGlWcVpaoSViiGBk9T7mgD5Y+PH/JVb" +
			"7/rhB/6AK94+C3/ACSXQ/8Adl/9GvXg/wAeP+Sq33/XCD/0AV7x8Fv+SS6H/uy/+jXoA72iiigArzb47" +
			"/8AJKdQ/wCu0H/owV6TXm3x3/5JTqH/AF2g/wDRgoA8e/Z8/wCSmH/rxl/mtet/HXXtW8P+CLWfSL2az" +
			"mlvkieWFtrbdjnGe3IFeSfs+f8AJTD/ANeMv81r6ivLG01G3NvfWsF1ASCY54w6kjpweKAPi/8A4WN40" +
			"/6GnVv/AAKf/Gj/AIWN40/6GnVv/Ap/8a+vv+EP8Mf9C5pH/gFH/wDE0f8ACH+GP+hc0j/wCj/+JoA+Q" +
			"f8AhY3jT/oadW/8Cn/xo/4WN40/6GnVv/Ap/wDGvr7/AIQ/wx/0Lmkf+AUf/wATR/wh/hj/AKFzSP8Aw" +
			"Cj/APiaAPkH/hY3jT/oadW/8Cn/AMa+k/gnrep698PVutWvJbu4S6kjEspyxUYIye/U11f/AAh/hj/oX" +
			"NI/8Ao//ia1LSztbC2S2s7aG3gT7sUKBFX6AcUAfKHx4/5Krff9cIP/AEAV7x8Fv+SS6H/uy/8Ao168H" +
			"+PH/JVb7/rhB/6AK94+C3/JJdD/AN2X/wBGvQB3tFFFABXm3x3/AOSU6h/12g/9GCvSa4/4oeHLvxV8P" +
			"tS0uwAa7ISWJCcbyjBtv1IBA96APBf2fP8Akph/68Zf5rX1TuHqPzr4Qm0nVrG5eGbT72CdDtZGhZWH6" +
			"U37Pqn/ADxvP++WoA+8dw9R+dG4eo/Ovg77Pqn/ADxvP++Wo+z6p/zxvP8AvlqAPvHcPUfnRuHqPzr4O" +
			"+z6p/zxvP8AvlqPs+qf88bz/vlqAPvHcPUfnRuHqPzr4O+z6p/zxvP++Wo+z6p/zxvP++WoA7347/8AJ" +
			"Vb7/rhB/wCgCvePgt/ySXQ/92X/ANGvXydbaLrGpXaW9vp17cXEhCqiwsxP6V9kfD3QLnwv4D0nSLwr9" +
			"pgiJlCnIVmYsRnvjdj8KAOmooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKAP/2Q==";
		internal const string B64Folderhumbnail =
		"data:image/jpeg;base64,/9j/4AAQSkZJRgABAQEAYABgAAD/2wCEAAgGBgcGBQgHBwcJCQgKDBQND" +
			"AsLDBkSEw8UHRofHh0aHBwgJC4nICIsIxwcKDcpLDAxNDQ0Hyc5PTgyPC4zNDIBCQkJDAsMGA0NGDIhH" +
			"CEyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMv/AABEIAGQAZ" +
			"AMBIgACEQEDEQH/xAGiAAABBQEBAQEBAQAAAAAAAAAAAQIDBAUGBwgJCgsQAAIBAwMCBAMFBQQEAAABf" +
			"QECAwAEEQUSITFBBhNRYQcicRQygZGhCCNCscEVUtHwJDNicoIJChYXGBkaJSYnKCkqNDU2Nzg5OkNER" +
			"UZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6g4SFhoeIiYqSk5SVlpeYmZqio6Slpqeoqaqys7S1t" +
			"re4ubrCw8TFxsfIycrS09TV1tfY2drh4uPk5ebn6Onq8fLz9PX29/j5+gEAAwEBAQEBAQEBAQAAAAAAA" +
			"AECAwQFBgcICQoLEQACAQIEBAMEBwUEBAABAncAAQIDEQQFITEGEkFRB2FxEyIygQgUQpGhscEJIzNS8" +
			"BVictEKFiQ04SXxFxgZGiYnKCkqNTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqCg" +
			"4SFhoeIiYqSk5SVlpeYmZqio6Slpqeoqaqys7S1tre4ubrCw8TFxsfIycrS09TV1tfY2dri4+Tl5ufo6" +
			"ery8/T19vf4+fr/2gAMAwEAAhEDEQA/APf6K8R8f+N/F2q/ERfA3gyVbWaJQZpvlDO2zefmI+VQpHTkm" +
			"qX/AAiPxw/6GWP/AMC//sKAPe6K8E/4RH44f9DLH/4F/wD2NUNYtfjR4Q059du9b+021oQ8qJKJflzyS" +
			"pUZX19OvvQB9FUVy/gHxna+OfC8GqwhY7gfu7qAHPlSDqPoeo9jXUUAFFFFABRRRQAUUUUAFFFFAHgem" +
			"f8AJ199/uN/6TLXvleB6Z/ydfff7jf+ky1694t8YaP4L0j+0dYnZEZtkUUY3SSt6KP6ngUAb1MmhjuIJ" +
			"IZkWSKRSjowyGUjBBHpXjf/AA0j4bzxo2q/lH/8VSf8NI+HP+gNqv5R/wDxVAGdd/BbxboOtXkvgfxIt" +
			"jp9yd3ltcSROo7KdoIYDJwetN/4V18Y/wDodh/4MZv/AIitP/hpHw5/0BtV/KP/AOKo/wCGkfDn/QG1X" +
			"8o//iqAMz/hXXxj/wCh2H/gxm/+Io/4V18Y/wDodh/4MZv/AIitP/hpHw5/0BtV/KP/AOKo/wCGkfDn/" +
			"QG1X8o//iqAMz/hXXxj/wCh2H/gxm/+Io/4V18Y/wDodh/4MZv/AIitP/hpHw5/0BtV/KP/AOKo/wCGk" +
			"fDn/QG1X8o//iqAMz/hXXxkHTxqP/BjN/8AEVu/B3xxrurapq/hXxLJ5+oaZkic43EK+xlYjg4OMHvzV" +
			"X/hpHw3/wBAbVfyj/8Aiq868CfEjSPDvxM13xDfW939j1My7BGqs8e+UOCwz2A7UAfVtFVNM1Oz1nTLf" +
			"UdPuEuLS4QPFKnRh/T6dqNM1Oz1nTLfUdPuEuLS4QPFKnRh/T6dqAPDtM/5Ovvv9xv/AEmWj4vgeIvjB" +
			"4S8Nkb4V8syoemJJPm/8dQUaZ/ydff/AO63/pMtGjf8VF+1FqN196LTFkx6DZGIv/QmJoA9oHhvQlUKu" +
			"i6cABgAWqcfpS/8I5of/QG07/wFT/CtOigDM/4RzQ/+gNp3/gKn+FH/AAjmh/8AQG07/wABU/wrTooAz" +
			"P8AhHND/wCgNp3/AICp/hR/wjmh/wDQG07/AMBU/wAK06KAMz/hHND/AOgNp3/gKn+FH/COaH/0BtO/8" +
			"BU/wrTooAzP+Ec0P/oDad/4Cp/hXG/FbStB074Za3cnSLBXEIWJlt0VldmCqQQMggnNei15B+0VqX2Xw" +
			"HaWKnDXl6uR6qilj+u2gDX+BdrLbfCrT2lYkTyzSoD/AArvI4/In8aPgXay23wq09pWJE8s0qA/wrvI4" +
			"/In8a6vwXpv9j+CdEsMYaGyiVx/tbQW/UmjwXpv9j+CdEsMYaGyiVx/tbQW/UmgDx2xlSD9qjUpZDhEj" +
			"dmPoBbDNTfs/wAT6p4g8V+I5R808gUE+ruzt/Ja5XxhqX9lfGjxdeBtrCwmRD/tPbKg/Vq9N/Z/077F8" +
			"NhdFcNe3ckufULhB/6CaAPVaWkpaACiiigAooooAKKKKACvBPjeTrnxF8IeGlO4Oys6j/prIF/khr3uv" +
			"BF/4qP9qcn70Olp+WyL/wCLagD3oAAAAYA6CgAAAAYA6ClooA+OPi45/wCFp69gkbnjBx3HlpX098PtO" +
			"/sn4f6DZFdrJZRs4/2mG4/qxr5p+Idk2qfGi9sV5a5u4IRj/aRB/WvraFFijWNBhEAVR7DgUATjpS0gp" +
			"aAFooooAKKKKACiiigBCQoJJwByTXg3wNB1v4geL/ErDIdiqsf+mshf+SCvXPGupf2R4H1u/Bw0NlKUP" +
			"+0VIX9SK4D9nfTfsvgG5vmHzXl65B9VQBR+u6gD12iiigD5oSyW+/aeCSY2x3KzYPcpAGGPxAr6PjVsd" +
			"D+VeU+NfhTa+MtQi1Wz1B9N1RFCtKE3LIB0JAIIYdMiufX4D+I26eOZP++JP/i6APfBS14KPgL4k/6Hm" +
			"T/viT/4uj/hQniT/oepP++JP/i6APe6K8F/4UJ4l/6HmT/viT/4uj/hQniX/oeZP++JP/i6APeqK8F/4" +
			"UJ4l/6HmT/viT/4uj/hQniX/oeZP++JP/i6APeqK8F/4UJ4l/6HmT/viT/4uj/hQniX/oeZP++JP/i6A" +
			"Os+PWpiw+GNxbh8PfXEUAHcgHef0T9a6D4X6b/ZXwz0C3K7Wa1WZh7yEv8A+zV53p/7Pc0uowS+IfFE2" +
			"oWkTbjAqMC/tuZjtB74GfpXt8UUcEKRRIEjRQqqowFA4AFAD6KKKAMS26CtKPoKI+goj6CgCcUtFFAC0" +
			"UUUAFFFFABRRRQAUUUUAFFFFAH/2Q==";
		internal const string B64ImageThumbnail =
			"data:image/jpeg;base64,/9j/4AAQSkZJRgABAQEAYABgAAD/2wCEAAgGBgcGBQgHBwcJCQgKDBQND" +
			"AsLDBkSEw8UHRofHh0aHBwgJC4nICIsIxwcKDcpLDAxNDQ0Hyc5PTgyPC4zNDIBCQkJDAsMGA0NGDIhH" +
			"CEyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMv/AABEIAGQAZ" +
			"AMBIgACEQEDEQH/xAGiAAABBQEBAQEBAQAAAAAAAAAAAQIDBAUGBwgJCgsQAAIBAwMCBAMFBQQEAAABf" +
			"QECAwAEEQUSITFBBhNRYQcicRQygZGhCCNCscEVUtHwJDNicoIJChYXGBkaJSYnKCkqNDU2Nzg5OkNER" +
			"UZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6g4SFhoeIiYqSk5SVlpeYmZqio6Slpqeoqaqys7S1t" +
			"re4ubrCw8TFxsfIycrS09TV1tfY2drh4uPk5ebn6Onq8fLz9PX29/j5+gEAAwEBAQEBAQEBAQAAAAAAA" +
			"AECAwQFBgcICQoLEQACAQIEBAMEBwUEBAABAncAAQIDEQQFITEGEkFRB2FxEyIygQgUQpGhscEJIzNS8" +
			"BVictEKFiQ04SXxFxgZGiYnKCkqNTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqCg" +
			"4SFhoeIiYqSk5SVlpeYmZqio6Slpqeoqaqys7S1tre4ubrCw8TFxsfIycrS09TV1tfY2dri4+Tl5ufo6" +
			"ery8/T19vf4+fr/2gAMAwEAAhEDEQA/APeqz9Q17R9IcJqWrWNm55C3FwqE/gTXI/FzxtP4L8IebYsF1" +
			"K9k8i3cjPl8ZZ8ew6e5FfJdzcz3lzJc3U0k88jbnkkYszH1JPWqBI+1P+E48J/9DNo//gbH/jR/wnHhP" +
			"/oZtH/8DY/8a+JqKLDsfbP/AAnHhP8A6GbR/wDwNj/xo/4Tjwn/ANDNo/8A4Gx/418TUUWCx9s/8Jx4T" +
			"/6GbR//AANj/wAaP+E48J/9DNo//gbH/jXxNRRYLH2z/wAJx4T/AOhm0f8A8DY/8aP+E48J/wDQzaP/A" +
			"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" +
			"ABRRRQAUUUUAFFFFABRRRQAUUUUAf/Z";
	}
}
