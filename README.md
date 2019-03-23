# 概要

簡易な音量調整アセットです。

期間の短いゲームジャムなどで、音量調整機能を作っている時間がない時やプロトタイプを作るときなどパパっと済ませたいときに使ってもらえるといいと思って作りました。   
もし、普通はこういう風に作らないとかあれば、教えてもらえると助かります。(すぐに反応できないこともありますが、それでもよければ)  
`issues`か[@stdmouse(twitter)](https://twitter.com/stdmouse)に連絡をください。  

![vc_sample](https://user-images.githubusercontent.com/1392476/54866345-01237b80-4db6-11e9-81c5-3990a7a80518.jpg)

# 使い方
## パッケージのインポート
1. [Releases](https://github.com/stdmouse/VolumeConfig/releases)から、最新の`unitypackage`をダウンロードしてください。  
  `volume_config.unitypackage`のリンクをクリックするとダウンロードできます。
1. UnityのAssets>Inport package>custom packageから取り込む  
  ![volumeConfig_readme_unityPackageInport](https://user-images.githubusercontent.com/1392476/54866503-d5a19080-4db7-11e9-888d-a30d241477fe.png)

## 音量調整モーダルを使う場合
1. 音量調整ボタンをシーンに追加してください。  
  音調調整ボタンのプレハブは`Assets/rachLab/volumeConfig/Prefabs/VolumeConfigButton`です。
1. 音量調整モーダル用のシーンをビルド対象に登録してください。  
  `File>Build Settings`のScenes In Buildに追加してください。

## 音量調整スライダーを使う場合
1. 音量調節スライダーをシーンに追加してください。  
  音量調整スライダーのプレハブは`Assets/rachLab/volumeConfig/Prefabs/VolumeArea`です。
2. Audio Mixerのパラメーター名を`VolumeArea/Slider`にアタッチされている`VolumeController`の`Paramater Name`に設定してください

| 対象のパラメータ | パラメーター名 | 
----|---- 
| マスター音量 | MastarVolume |
| BGNの音量 | BGMVolume |
| SEの音量 | SEVolume |

## 音を追加するときにすること
BGMやSEを鳴らすときに`Audio Source`を追加するはずです。このコンポーネントの`Output`に`MasterAudioMixer`のいずれかのパラメーターを指定してください。

### Tips
音を追加するときに設定した`Output`のパラメーター名でどの音が変更するかが決まります。  
そのため、音を追加するときは、`BGM`、`SE`のどちらかを設定するようにしてください。
こうしておけば、マスターのみの音量調整スライダーを使う場合でも、すべての音が対象となります。  
`Master`を指定してもいいですが、あとで分けたくなった場合に再度設定しなおす必要があります。めんどうですよね。

# テスト用の音源について
[魔王魂](https://maoudamashii.jokersounds.com/)
