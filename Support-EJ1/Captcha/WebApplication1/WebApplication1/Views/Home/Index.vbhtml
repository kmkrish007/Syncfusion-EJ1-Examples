@Code
    ViewData("Title") = "Home Page"
End Code

<div>
    @Html.EJ().Captcha("SignUpCaptcha").EnableAudio(True).EnableRefreshImage(True).RequestMapper(Url.Action("Refresh"))
</div>

<div id="captcha" style="height:66px; width:210px;">
    <div class="imagecontainer">
        <img id="captcha_CaptchaImage" src="@ViewBag.CaptchaUrl" />
    </div>
    <div style="margin-top:0px;height:66px;float:left;width:50px">
        <audio id="captcha_AudioObject" src="@ViewBag.CaptchaUrl&audio=true"></audio>
        <button class="audio" id="captcha_PlayAudio" type="button" />
        <button class="refresh" id="captcha_RefreshButton" type="button" />
    </div>
    <span class="spanText" id="captcha_CaptchaMessage" />
    <input id="captcha_Hidden" name="captcha" type="hidden" value="@ViewBag.EncryptedCode" />
</div>
<input autoComplete="off" class="validTextBox" name="validateText" placeholder="Inserisci qui il codice" type="text" />
@Html.ValidationMessage("captchaErrors")<br /><br />

<script>
    $(function () {

        $("#captcha").ejCaptcha({
            characterSet: "ABCD1234",
            maximumLength: 4,
            showAudioButton: true,
            enableAutoValidation: false,
            customErrorMessage: "",
            audioUrl: "",
            requestMapper: "/Home/Refresh",
            pathName: "",
            mapper: "",
            encryptedCode: "@ViewBag.EncryptedCode",
            targetInput: "",
            targetButton: "",
            showRefreshButton: true
        });
    });
</script>