using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Satan_Records_Audio_Player
{
    internal class Class1
    {
        public string htmlplayer = @"<script type=\""text/javascript\"">
const bands = ['Phantom', 'Sewer', 'Neraines', 'Vermin', 'Leader', 'Playlist'];
const albums = [
	[
		['Dementia', 'https://s-media-cache-ak0.pinimg.com/564x/dd/32/b0/dd32b03f30b3ecf0c5cca08979d5c74a.jpg', 'https://open.spotify.com/embed/album/2Vq6kV9WDgcopFzy5coqDc'],
		['Withdrawal', 'https://i.pinimg.com/564x/f1/26/d5/f126d5813833ee39905fada6342fd285.jpg', 'https://open.spotify.com/embed/album/2WsrNjTR3zI1enOEgibJjp'],
		['Fallen Angel', 'https://i.pinimg.com/564x/cd/72/cd/cd72cd76a3414e6dcbc17cd89fa63807.jpg', 'https://open.spotify.com/embed/album/5bviwevmG1HlNIlT7XVOqH'],
		['Ascension of Erebos', 'https://i.pinimg.com/564x/70/4e/c7/704ec7001adccf257f4f6f58fd826376.jpg', 'https://open.spotify.com/embed/album/55KuFAxrrvAiUWB8FbK2Zc'],
	],
	[
		['Miasma', 'https://i.pinimg.com/564x/7a/bc/1c/7abc1c5879110cec51be3bdaa4648373.jpg', 'https://open.spotify.com/embed/album/6dIOCTOwjkkeGsW9iYKCgW'],
		['Khranial', 'https://i.pinimg.com/564x/b5/d7/79/b5d77950dca687a69ba5e677d7ca6948.jpg', 'https://open.spotify.com/embed/album/2uRhvZNFnzmWbpRGvZCJD9'],
		['Uruktena', 'https://i.pinimg.com/564x/7e/5b/42/7e5b42cdc7cfac6562eea52ae8501500.jpg', 'https://open.spotify.com/embed/album/3wRd8T7PVcXJWcTLN0cvG8'],
		['Cathartes', 'https://i.pinimg.com/564x/78/5a/81/785a81aa8ed687886981024d1000be25.jpg', 'https://open.spotify.com/embed/album/6dSaXSqjmlrZwPQ9FNXPrq'],
	],
	[
		['Yggdrasil', 'https://i-h2.pinimg.com/564x/a4/e9/65/a4e965f4b83e6a4ec83fa3f2edb98dbe.jpg', 'https://open.spotify.com/embed/album/3yQKuOi6gVEdntTNn1ZTqf'],
		['Fenrir Prowling', 'https://i.pinimg.com/564x/3f/f6/1a/3ff61a48572ca7ee95fde0f8afbb5554.jpg', 'https://open.spotify.com/embed/album/2tWK3dI8kJTWd60edhBWjm'],
	],
	[
		['Bloodthirst Overdose', 'https://i.pinimg.com/564x/dd/a6/ed/dda6ed5f9b7c9b4f9596eb6aec4fcd99.jpg', 'https://open.spotify.com/embed/album/77NmzFO92nqD1LlF4uIbEs'],
	],
	[
		['Burzum Sha Ghâsh', 'https://i.pinimg.com/564x/1f/48/e8/1f48e8e2509fe7d96aab4171eeb88915.jpg', 'https://open.spotify.com/embed/album/6nJHIJ9NUG7bEWerp0RS0R'],
	],
	[
		['The Satan Records: Essentials', 'https://i.pinimg.com/564x/e4/ef/95/e4ef9576acda3ee4a82057309c2b6fc3.jpg', 'https://open.spotify.com/embed/playlist/3PP6GCJWSmi6DKEWdr5nJ6'],
	],
];

const data_style = ['none', 'block', 'inline'];
const data_display = [
	['band_select', 0],
	['album_list', 0],
	['player', 0],
	['disc', 1],
];

function d_check(select, target) {
	if(data_display[select][1] != target) {
		document.getElementById(data_display[select][0]).style.display = data_style[target];
		data_display[select][1] = target;
	}
}

function band_switch(id) {
	document.getElementById('h2').innerHTML = bands[id];
	document.getElementById('ph2').innerHTML = bands[id];
	list_albums(id);
	d_check(0, 1); d_check(1, 1); d_check(2, 0); d_check(3, 1);
}

function list_albums(id) {
	let html = '<ul>';
	let i = 0; let c = albums[id].length;
	for (i = 0; i < c; ++i) {
		html += '<li><a href=\""javascript:;\"" onclick=\""album_show('+id+', '+i+');\"" ><figure><figcaption>' + albums[id][i][0] + '</figcaption><img src=\""' + albums[id][i][1] + '\"" alt=\""' + albums[id][i][0] + '\"" /></figure></a></li>';
	}
	html += '</ul>';
	document.getElementById('album_list').innerHTML = html;
}

function album_show(b, a) {
	document.getElementById('tlisten').innerHTML = albums[b][a][0];
	document.getElementById('rplayer').src = albums[b][a][2];
	document.getElementById('back').setAttribute('onClick', 'javascript:bback('+b+');');
	document.getElementById('sback').innerHTML = bands[b];
	d_check(0, 0); d_check(1, 0); d_check(3, 0);
	d_check(2, 1);
}

function bback(id) {
	d_check(2, 0); d_check(3, 1);
	band_switch(id);
}

</script>
<!DOCTYPE html>
<html>
<head>
	<meta charset=\""utf-8\"" />
	<title>The Satan Records Audio Player</title><meta name=\""description\"" content=\""The Satan Records Audio Player\"">
	<meta name=\""viewport\"" content=\""width=device-width, initial-scale=1\""/>
</head>
<body>
<h1>The Satan Records</h1>
<nav>
	<ul>
		<li><a href=\""javascript:;\"" onclick=\""band_switch(0);\"">Phantom</a></li>
		<li><a href=\""javascript:;\"" onclick=\""band_switch(1);\"">Sewer</a></li>
		<li><a href=\""javascript:;\"" onclick=\""band_switch(2);\"">Neraines</a></li>
		<li><a href=\""javascript:;\"" onclick=\""band_switch(3);\"">Vermin</a></li>
		<li><a href=\""javascript:;\"" onclick=\""band_switch(4);\"">Leader</a></li>
		<li><a href=\""javascript:;\"" onclick=\""band_switch(5);\"">Playlist</a></li>
	</ul>
</nav>

<main>
<div id=\""band_select\"" style=\""display:none;\""><h2><span id=\""h2\""></span> Albums</h2><p>Click on any <span id=\""ph2\""></span> album to display the tracklist.</p></div>
<div id=\""album_list\"" style=\""display:none;\""></div>
<div id=\""player\"" style=\""display:none;\""><h2>Listen to \""<span id=\""tlisten\""></span>\""</h2><div id=\""splayer\""><iframe id=\""rplayer\"" src=\""https://open.spotify.com/embed/playlist/3PP6GCJWSmi6DKEWdr5nJ6\"" width=\""100%\"" height=\""335\"" frameBorder=\""0\"" allowfullscreen=\""\"" allow=\""autoplay; clipboard-write; encrypted-media; fullscreen; picture-in-picture\""></iframe></div><p><a id=\""back\"" href=\""javascript:;\"">Back to <span id=\""sback\""></span> Albums</a></p></div>
<div id=\""disc\""><strong>Disclosure:</strong> The 'music' presented on this application can cause seizures in the medically prone, and prolonged exposure may result in psychotic breaks, delusions, dementia and other psychosomatic afflictions. Please consult a physician before listening to products from The Satan Records or any bands thereof.</div>
</main>
</body>
</html>
<style>
@font-face{font-family:'TSR';src:url(https://thesatanrecords.github.io/TSR.otf)}@font-face {font-family: 'Roboto Slab';font-style: normal;font-weight: 400;src: url(https://fonts.gstatic.com/s/robotoslab/v22/BngbUXZYTXPIvIBgJJSb6s3BzlRRfKOFbvjojISmb2Rj.woff2) format('woff2');unicode-range: U+0000-00FF, U+0131, U+0152-0153, U+02BB-02BC, U+02C6, U+02DA, U+02DC, U+2000-206F, U+2074, U+20AC, U+2122, U+2191, U+2193, U+2212, U+2215, U+FEFF, U+FFFD;}@font-face {font-family: 'Roboto Slab';font-style: normal;font-weight: 700;src: url(https://fonts.gstatic.com/s/robotoslab/v22/BngbUXZYTXPIvIBgJJSb6s3BzlRRfKOFbvjoa4Omb2Rj.woff2) format('woff2');unicode-range: U+0000-00FF, U+0131, U+0152-0153, U+02BB-02BC, U+02C6, U+02DA, U+02DC, U+2000-206F, U+2074, U+20AC, U+2122, U+2191, U+2193, U+2212, U+2215, U+FEFF, U+FFFD;}
body{background:#fff;color:#777;padding:0;margin:0;font: 14px/1.75 arial;}
h1 {font: normal 22px/54px TSR;color: #222;text-align: center;height: 48px;}
h2 {color: #333;font-size: 22px;font-family: \""Roboto Slab\"",\""Helvetica Neue\"",Helvetica,Arial,sans-serif;margin: 18px auto;font-weight: normal;}
p {
  font-family: \""Roboto Slab\"",\""Helvetica Neue\"",Helvetica,Arial,sans-serif;
}
main {
	margin-top: 2rem;
	text-align: center;
}
nav {
	height: 2.5rem;line-height: 2.5rem;background:#222;
	display: flex;
  width: 100%;
}
nav ul {
	padding: 0;
  list-style: none;
  height: 100%;
  margin: 0 auto;
  max-width: 73.5rem;
  display: flex;
  gap: 1rem;
  flex-direction: row;
  align-items: center;
  flex-wrap: wrap;
}
nav ul li a {
		display: block;
    padding: 0.1rem 0.6rem;
    font-size: 0.9rem;
    height: 1.8rem;
    line-height: 1.8rem;
    border-radius: 0.25rem;
    color: #fff;
    text-decoration: none;
}
nav ul li a:hover {
    color: #fff;
    background-color: #424242;
}
#album_list ul {
	list-style-type: none;
	display: flex;
	flex-direction: row;
	justify-content: space-evenly;
	flex-wrap: wrap;
}
#album_list li {
	margin: 0;padding: 0;box-sizing: border-box;
}
#album_list figure {
	max-width: 200px;
	text-align: center;
	box-sizing: border-box;
  border: 1px solid #eee;
  padding: 16px;
  margin: 5px;
}
#album_list figcaption {
	padding-bottom: 10px;
}
#album_list img {
	vertical-align: bottom;
	max-width: 90%;
	margin: 0 auto 10px;
	box-shadow: 8px 8px 6px -6px #888;
}
#album_list a, #back {
	color: #444;
}
#splayer {max-width: 61%;margin: auto;}
#disc {
	max-width: 75%;
  margin: 15px auto;
  background: #f7f7f7;
  padding: 18px;
  font-style: italic;
  border: 1px solid #e4e4e4;
}
@media screen and (max-width: 800px) {
	#splayer {max-width: 85%;}
}
</style>";

    }
}
